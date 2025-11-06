using todo_app.controller;
using todo_app.entity;
using todo_app.service;
using todo_app.view;

namespace todo_app;

public partial class Form1 : Form
{
    private Controller _controller;
    private TagService _tagService;
    private TodoService _todoService;
    private FileService _fileService;

    private LoggedInAccount _loggedInAccount;

    private Tag? _currentTag = null;
    private List<Todo>? _currentTodos = null;
    public Form1()
    {
        InitializeComponent();
    }
    public Form1(Controller controller)
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
            dgvTodos.Columns["Priority"].Visible = false;
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
            string content = tbCreateTodo.Text;
            _todoService.Create(content, _currentTag);

            tbCreateTodo.Clear();
            LoadTodos();
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