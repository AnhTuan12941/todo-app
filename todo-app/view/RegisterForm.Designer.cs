using System.ComponentModel;

namespace todo_app;

partial class RegisterForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(RegisterForm));
        btnLogin = new Button();
        label4 = new Label();
        btnRegister = new Button();
        tBCofirmPassword = new TextBox();
        label3 = new Label();
        tbPassword = new TextBox();
        label2 = new Label();
        tBUsername = new TextBox();
        label1 = new Label();
        panel1 = new Panel();
        label5 = new Label();
        panel2 = new Panel();
        pictureBox1 = new PictureBox();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 13F);
        btnLogin.Location = new Point(12, 334);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(263, 47);
        btnLogin.TabIndex = 8;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Font = new Font("Segoe UI", 11F);
        label4.Location = new Point(12, 303);
        label4.Name = "label4";
        label4.Size = new Size(263, 28);
        label4.TabIndex = 7;
        label4.Text = "hoặc";
        label4.TextAlign = ContentAlignment.TopCenter;
        // 
        // btnRegister
        // 
        btnRegister.BackColor = SystemColors.MenuHighlight;
        btnRegister.FlatStyle = FlatStyle.Flat;
        btnRegister.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnRegister.ForeColor = SystemColors.Window;
        btnRegister.Location = new Point(12, 253);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(263, 47);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Đăng ký";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // tBCofirmPassword
        // 
        tBCofirmPassword.Font = new Font("Segoe UI", 13F);
        tBCofirmPassword.Location = new Point(12, 216);
        tBCofirmPassword.Name = "tBCofirmPassword";
        tBCofirmPassword.Size = new Size(263, 31);
        tBCofirmPassword.TabIndex = 5;
        tBCofirmPassword.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI", 13F);
        label3.Location = new Point(12, 185);
        label3.Name = "label3";
        label3.Size = new Size(263, 28);
        label3.TabIndex = 4;
        label3.Text = "Nhập lại mật khẩu";
        // 
        // tbPassword
        // 
        tbPassword.Font = new Font("Segoe UI", 13F);
        tbPassword.Location = new Point(12, 151);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new Size(263, 31);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 13F);
        label2.Location = new Point(12, 120);
        label2.Name = "label2";
        label2.Size = new Size(263, 28);
        label2.TabIndex = 2;
        label2.Text = "Mật khẩu";
        // 
        // tBUsername
        // 
        tBUsername.Font = new Font("Segoe UI", 13F);
        tBUsername.Location = new Point(12, 86);
        tBUsername.Name = "tBUsername";
        tBUsername.Size = new Size(263, 31);
        tBUsername.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI", 13F);
        label1.Location = new Point(12, 55);
        label1.Name = "label1";
        label1.Size = new Size(263, 28);
        label1.TabIndex = 0;
        label1.Text = "Tài khoản";
        // 
        // panel1
        // 
        panel1.Controls.Add(label5);
        panel1.Controls.Add(btnLogin);
        panel1.Controls.Add(btnRegister);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(tBUsername);
        panel1.Controls.Add(tBCofirmPassword);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(tbPassword);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(287, 450);
        panel1.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label5.Location = new Point(12, 25);
        label5.Name = "label5";
        label5.Size = new Size(98, 30);
        label5.TabIndex = 9;
        label5.Text = "Đăng ký";
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.Window;
        panel2.Controls.Add(label6);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(pictureBox1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(287, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(513, 450);
        panel2.TabIndex = 2;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(6, 131);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(200, 200);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 13F);
        label6.ForeColor = SystemColors.MenuHighlight;
        label6.Location = new Point(212, 255);
        label6.Name = "label6";
        label6.Size = new Size(83, 25);
        label6.TabIndex = 6;
        label6.Text = "Hiệu quả";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 13F);
        label7.ForeColor = SystemColors.MenuHighlight;
        label7.Location = new Point(212, 226);
        label7.Name = "label7";
        label7.Size = new Size(68, 25);
        label7.TabIndex = 5;
        label7.Text = "Tiện lợi";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        label8.Location = new Point(212, 185);
        label8.Name = "label8";
        label8.Size = new Size(213, 41);
        label8.TabIndex = 4;
        label8.Text = "Task Manager";
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "RegisterForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng ký";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tBUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tBCofirmPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnLogin;

    #endregion

    private Panel panel1;
    private Label label5;
    private Panel panel2;
    private PictureBox pictureBox1;
    private Label label6;
    private Label label7;
    private Label label8;
}