using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.repository;

namespace todo_app.service;

public class AccountService
{
    private AccountRepository _accountRepository;
    private LoggedInAccount _loggedInAccount;
    
    public AccountService(Controller controller)
    {
        _accountRepository = controller.AccountRepository;
        _loggedInAccount = controller.LoggedInAccount;
    }

    public void Register(string? username, string? password, string? confirmPassword)
    {
        ValidateUsername(username);
        ValidatePassword(password);
        
        if (string.IsNullOrEmpty(confirmPassword))
        {
            throw new AppException("Nhập lại mật khẩu không hợp lệ.");
        }
        
        if (password != confirmPassword)
        {
            throw new AppException("Mật khẩu không khớp.");
        }

        Account? account = _accountRepository.FindByUsername(username);
        bool isExisted = account != null;
        if (isExisted)
        {
            throw new AppException("Tài khoản đã tồn tại.");
        }

        account = new Account
        {
            Username = username,
            Password = password
        };

        _accountRepository.Create(account);
    }

    private void ValidateUsername(string? username)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new AppException("Tài khoản không hợp lệ.");
        }
        if (username.Length < 5)
        {
            throw new AppException("Tài khoản phải có ít nhất 5 ký tự.");
        }
        if (username.Length > 20)
        {
            throw new AppException("Tài khoản không được quá 20 ký tự.");
        }
    }

    private void ValidatePassword(string? password)
    {
        if (string.IsNullOrEmpty(password))
        {
            throw new AppException("Mật khẩu không hợp lệ.");
        }
        if (password.Length < 5)
        {
            throw new AppException("Mật khẩu phải có ít nhất 5 ký tự");
        }
        if (password.Length > 20)
        {
            throw new AppException("Mật khẩu không được quá 20 ký tự");
        }
    }

    public void Login(string? username, string? password)
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new AppException("Tài khoản không hợp lệ");
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new AppException("Mật khẩu không hợp lệ");
        }
        
        Account? account = _accountRepository.FindByUsername(username);
        
        bool isExisted = account != null;
        if (!isExisted)
        {
            throw new AppException("Tài khoản không tồn tại");
        }

        bool isValidPassword = password == account.Password;
        if (!isValidPassword)
        {
            throw new AppException("Mật khẩu không đúng");
        }
        
        _loggedInAccount.SetAccount(account);
    }
}