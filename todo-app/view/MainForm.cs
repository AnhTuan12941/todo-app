using todo_app.controller;
using todo_app.entity;
using todo_app.service;
using todo_app.view;

namespace todo_app;

public partial class MainForm : Form
{
    private Controller _controller;
    private TagService _tagService;
    private TodoService _todoService;
    private FileService _fileService;

    private LoggedInAccount _loggedInAccount;

    private Tag? _currentTag = null;
    private List<Todo>? _currentTodos = null;
    private Todo? _currentTodo = null;
    public MainForm()
    {
        InitializeComponent();
    }
    public MainForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _tagService = controller.TagService;
        _todoService = controller.TodoService;
        _fileService = controller.FileService;

        _loggedInAccount = controller.LoggedInAccount;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!_loggedInAccount.IsLoggedIn())
        {
            var loginForm = new LoginForm(_controller);
            loginForm.ShowDialog();
        }

        LoadTags();
        LoadTodos();

        HideRightSideBar();
    }

    private void btnToggleLeftSideBar_Click(object sender, EventArgs e)
    {
        panelLeftSideBar.Width = panelLeftSideBar.Width == 0 ? 250 : 0;
    }

    private void LoadTags()
    {
        var tags = _tagService.FindAll();
        dgvTags.DataSource = tags.OrderBy(t => t.Name).ToList();

        try
        {
            dgvTags.Columns["Id"].Visible = false;
            dgvTags.Columns["AccountId"].Visible = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void LoadTodos()
    {
        if (_currentTag == null)
        {
            dgvTodos.DataSource = null;
            return;
        }

        _currentTodos = _todoService.FindByTagId(_currentTag.Id);
        dgvTodos.DataSource = null;
        dgvTodos.DataSource = _currentTodos.OrderBy(t => t.IsDone).ToList();

        try
        {
            dgvTodos.Columns["Id"].Visible = false;
            dgvTodos.Columns["Note"].Visible = false;
            dgvTodos.Columns["DueDate"].Visible = false;
            dgvTodos.Columns["TagId"].Visible = false;

            dgvTodos.Columns["IsDone"].Width = 50;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void tbCreateTag_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string tagName = tbCreateTag.Text;
            _tagService.Create(tagName);

            tbCreateTag.Clear();
            LoadTags();
        }
    }

    private void tbCreateTodo_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            CreateTodo();
        }
    }

    private void dgvTags_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var selectedTag = dgvTags.Rows[e.RowIndex].DataBoundItem as Tag;

        if (selectedTag == null)
        {
            return;
        }

        _currentTag = selectedTag;
        lbTagName.Text = _currentTag.Name;
        LoadTodos();
    }

    private void btnHideRightSideBar_Click(object sender, EventArgs e)
    {
        HideRightSideBar();
    }

    private void ShowRightSideBar(Todo todo)
    {
        if (todo == null)
        {
            return;
        }
        rbtnCheckTodo.Checked = todo.IsDone;
        lbCurrentTodoName.Text = todo.Content;
        dtpCurrentTodoDueDate.Value = todo.DueDate ?? DateTime.Now;
        tbCurrentTodoNote.Text = todo.Note;

        panelRightSideBar.Width = 300;
    }

    private void HideRightSideBar()
    {
        panelRightSideBar.Width = 0;
    }

    private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var selectedTodo = dgvTodos.Rows[e.RowIndex].DataBoundItem as Todo;

        if (selectedTodo == null)
        {
            return;
        }

        _currentTodo = selectedTodo;
        ShowRightSideBar(selectedTodo);
    }

    private void tbCreateTodo_TextChanged(object sender, EventArgs e)
    {
        if (tbCreateTodo.Text.Length > 0)
        {
            btnCreateTodo.Enabled = true;
        }
        else
        {
            btnCreateTodo.Enabled = false;
        }
    }

    private void btnCreateTodo_Click(object sender, EventArgs e)
    {
        CreateTodo();
    }

    private void CreateTodo()
    {
        string content = tbCreateTodo.Text;
        DateTime dueDate = dtpCreateTodo.Value;
        _todoService.Create(content, dueDate, _currentTag);

        tbCreateTodo.Clear();
        LoadTodos();
    }

    private void btnDeleteTodo_Click(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }

        _todoService.Delete(_currentTodo.Id);
        HideRightSideBar();
        LoadTodos();
    }

    private void btnUserMenu_Click(object sender, EventArgs e)
    {
        Control control = sender as Control;

        Point menuPosition = new Point(
            0,
            control.Height
        );

        if (_loggedInAccount.IsLoggedIn())
        {
            cmsUserMenu.Items["miLogin"].Visible = false;
            cmsUserMenu.Items["miRegister"].Visible = false;
        }
        if (!_loggedInAccount.IsLoggedIn())
        {
            cmsUserMenu.Items["miExportFile"].Visible = false;
            cmsUserMenu.Items["miLogout"].Visible = false;
        }

        cmsUserMenu.Show(control, menuPosition);
    }

    private void miExportFile_Click(object sender, EventArgs e)
    {
        sfdExcel.Filter = "Excel Workbook|*.xlsx";
        sfdExcel.Title = "Chọn vị trí lưu file Excel";
        sfdExcel.FileName = $"Todo_By_Tags_{DateTime.Now:yyyyMMdd}.xlsx";
        if (sfdExcel.ShowDialog() == DialogResult.OK)
        {
            if (_fileService.ExportFileExcel(sfdExcel.FileName))
            {
                MessageBox.Show("Xuất file Excel thành công!\nĐã lưu tại: " + sfdExcel.FileName,
                    "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void btnTagMenu_Click(object sender, EventArgs e)
    {
        Control control = sender as Control;

        Point menuPosition = new Point(
            0,
            control.Height
        );

        cmsTagMenu.Show(control, menuPosition);
    }

    private void miDrawChart_Click(object sender, EventArgs e)
    {
        var chartForm = new view.ChartForm(_controller, _currentTag!);
        chartForm.ShowDialog();
    }

    private void miDeleteTag_Click(object sender, EventArgs e)
    {
        _tagService.Delete(_currentTag.Id);
        _currentTag = null;
        LoadTags();
        LoadTodos();
    }

    //private void btnExportFileExcel_Click(object sender, EventArgs e)
    //{
    //    sfdExcel.Filter = "Excel Workbook|*.xlsx";
    //    sfdExcel.Title = "Chọn vị trí lưu file Excel";
    //    sfdExcel.FileName = $"Todo_By_Tags_{DateTime.Now:yyyyMMdd}.xlsx";
    //    if (sfdExcel.ShowDialog() == DialogResult.OK)
    //    {
    //        if (_fileService.ExportFileExcel(sfdExcel.FileName))
    //        {
    //            MessageBox.Show("Xuất file Excel thành công!\nĐã lưu tại: " + sfdExcel.FileName,
    //                "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //        }
    //    }
    //}

    //private void btnShowChart_Click(object sender, EventArgs e)
    //{
    //    var chartForm = new view.ChartForm(_controller, _currentTag!);
    //    chartForm.ShowDialog();
    //}
}