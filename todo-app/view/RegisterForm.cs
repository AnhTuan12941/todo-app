using todo_app.controller;
using todo_app.service;

namespace todo_app;

public partial class RegisterForm : Form
{
    private AccountService _accountService;
    
    public RegisterForm(Controller controller)
    {
        InitializeComponent();
        _accountService = controller.AccountService;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = tBUsername.Text;
        string password = tbPassword.Text;
        string confirmPassword = tBCofirmPassword.Text;
        _accountService.Register(username, password, confirmPassword);

        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK);
        Close();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        Close();
    }
}