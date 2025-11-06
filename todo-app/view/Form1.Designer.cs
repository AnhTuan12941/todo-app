namespace todo_app;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        sfdExcel = new SaveFileDialog();
        panelHeader = new Panel();
        btnToggleLeftSideBar = new Button();
        panelLeftSideBar = new Panel();
        dgvTags = new DataGridView();
        tbCreateTag = new TextBox();
        panelRightSideBar = new Panel();
        panelMainContent = new Panel();
        dgvTodos = new DataGridView();
        dtpCreateTodo = new DateTimePicker();
        tbCreateTodo = new TextBox();
        lbTagName = new Label();
        panelHeader.SuspendLayout();
        panelLeftSideBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
        panelMainContent.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = SystemColors.MenuHighlight;
        panelHeader.Controls.Add(btnToggleLeftSideBar);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(1264, 50);
        panelHeader.TabIndex = 0;
        // 
        // btnToggleLeftSideBar
        // 
        btnToggleLeftSideBar.Dock = DockStyle.Left;
        btnToggleLeftSideBar.FlatAppearance.BorderSize = 0;
        btnToggleLeftSideBar.FlatStyle = FlatStyle.Flat;
        btnToggleLeftSideBar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnToggleLeftSideBar.ForeColor = SystemColors.Window;
        btnToggleLeftSideBar.Location = new Point(0, 0);
        btnToggleLeftSideBar.Name = "btnToggleLeftSideBar";
        btnToggleLeftSideBar.Size = new Size(60, 50);
        btnToggleLeftSideBar.TabIndex = 0;
        btnToggleLeftSideBar.Text = "| | |";
        btnToggleLeftSideBar.UseVisualStyleBackColor = true;
        btnToggleLeftSideBar.Click += btnToggleLeftSideBar_Click;
        // 
        // panelLeftSideBar
        // 
        panelLeftSideBar.BackColor = SystemColors.Window;
        panelLeftSideBar.Controls.Add(dgvTags);
        panelLeftSideBar.Controls.Add(tbCreateTag);
        panelLeftSideBar.Dock = DockStyle.Left;
        panelLeftSideBar.Location = new Point(0, 50);
        panelLeftSideBar.Name = "panelLeftSideBar";
        panelLeftSideBar.Size = new Size(250, 671);
        panelLeftSideBar.TabIndex = 1;
        // 
        // dgvTags
        // 
        dgvTags.AllowUserToAddRows = false;
        dgvTags.AllowUserToDeleteRows = false;
        dgvTags.AllowUserToOrderColumns = true;
        dgvTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTags.BackgroundColor = SystemColors.Window;
        dgvTags.BorderStyle = BorderStyle.None;
        dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTags.Dock = DockStyle.Fill;
        dgvTags.Location = new Point(0, 27);
        dgvTags.Name = "dgvTags";
        dgvTags.ReadOnly = true;
        dgvTags.Size = new Size(250, 644);
        dgvTags.TabIndex = 1;
        dgvTags.CellClick += dgvTags_CellClick;
        // 
        // tbCreateTag
        // 
        tbCreateTag.Dock = DockStyle.Top;
        tbCreateTag.Font = new Font("Segoe UI", 11F);
        tbCreateTag.Location = new Point(0, 0);
        tbCreateTag.Name = "tbCreateTag";
        tbCreateTag.PlaceholderText = "+ Danh sách mới";
        tbCreateTag.Size = new Size(250, 27);
        tbCreateTag.TabIndex = 0;
        tbCreateTag.KeyDown += tbCreateTag_KeyDown;
        // 
        // panelRightSideBar
        // 
        panelRightSideBar.BackColor = SystemColors.Window;
        panelRightSideBar.Dock = DockStyle.Right;
        panelRightSideBar.Location = new Point(964, 50);
        panelRightSideBar.Name = "panelRightSideBar";
        panelRightSideBar.Size = new Size(300, 671);
        panelRightSideBar.TabIndex = 2;
        // 
        // panelMainContent
        // 
        panelMainContent.BackColor = SystemColors.Control;
        panelMainContent.Controls.Add(dgvTodos);
        panelMainContent.Controls.Add(dtpCreateTodo);
        panelMainContent.Controls.Add(tbCreateTodo);
        panelMainContent.Controls.Add(lbTagName);
        panelMainContent.Dock = DockStyle.Fill;
        panelMainContent.Location = new Point(250, 50);
        panelMainContent.Name = "panelMainContent";
        panelMainContent.Size = new Size(714, 671);
        panelMainContent.TabIndex = 3;
        // 
        // dgvTodos
        // 
        dgvTodos.AllowUserToAddRows = false;
        dgvTodos.AllowUserToDeleteRows = false;
        dgvTodos.BackgroundColor = SystemColors.Control;
        dgvTodos.BorderStyle = BorderStyle.None;
        dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTodos.Location = new Point(0, 87);
        dgvTodos.Name = "dgvTodos";
        dgvTodos.ReadOnly = true;
        dgvTodos.Size = new Size(714, 584);
        dgvTodos.TabIndex = 3;
        // 
        // dtpCreateTodo
        // 
        dtpCreateTodo.Format = DateTimePickerFormat.Short;
        dtpCreateTodo.Location = new Point(6, 58);
        dtpCreateTodo.Name = "dtpCreateTodo";
        dtpCreateTodo.Size = new Size(102, 23);
        dtpCreateTodo.TabIndex = 2;
        // 
        // tbCreateTodo
        // 
        tbCreateTodo.Dock = DockStyle.Top;
        tbCreateTodo.Font = new Font("Segoe UI", 11F);
        tbCreateTodo.Location = new Point(0, 25);
        tbCreateTodo.Name = "tbCreateTodo";
        tbCreateTodo.PlaceholderText = "+ Thêm tác vụ";
        tbCreateTodo.Size = new Size(714, 27);
        tbCreateTodo.TabIndex = 1;
        tbCreateTodo.KeyDown += tbCreateTodo_KeyDown;
        // 
        // lbTagName
        // 
        lbTagName.AutoSize = true;
        lbTagName.Dock = DockStyle.Top;
        lbTagName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lbTagName.Location = new Point(0, 0);
        lbTagName.Name = "lbTagName";
        lbTagName.Size = new Size(63, 25);
        lbTagName.TabIndex = 0;
        lbTagName.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1264, 721);
        Controls.Add(panelMainContent);
        Controls.Add(panelRightSideBar);
        Controls.Add(panelLeftSideBar);
        Controls.Add(panelHeader);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        panelHeader.ResumeLayout(false);
        panelLeftSideBar.ResumeLayout(false);
        panelLeftSideBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
        panelMainContent.ResumeLayout(false);
        panelMainContent.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private System.Windows.Forms.SaveFileDialog sfdExcel;
    private Panel panelHeader;
    private Panel panelLeftSideBar;
    private Panel panelRightSideBar;
    private Panel panelMainContent;
    private Button btnToggleLeftSideBar;
    private DataGridView dgvTags;
    private TextBox tbCreateTag;
    private TextBox tbCreateTodo;
    private Label lbTagName;
    private DataGridView dgvTodos;
    private DateTimePicker dtpCreateTodo;
}
