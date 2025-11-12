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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
        btnLogin = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        btnRegister = new System.Windows.Forms.Button();
        tBCofirmPassword = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        tbPassword = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        tBUsername = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        panel1 = new System.Windows.Forms.Panel();
        label5 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label6 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // btnLogin
        // 
        btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnLogin.Font = new System.Drawing.Font("Segoe UI", 13F);
        btnLogin.Location = new System.Drawing.Point(12, 334);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(263, 47);
        btnLogin.TabIndex = 8;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 11F);
        label4.Location = new System.Drawing.Point(12, 303);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(263, 28);
        label4.TabIndex = 7;
        label4.Text = "hoặc";
        label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // btnRegister
        // 
        btnRegister.BackColor = System.Drawing.SystemColors.MenuHighlight;
        btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        btnRegister.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        btnRegister.ForeColor = System.Drawing.SystemColors.Window;
        btnRegister.Location = new System.Drawing.Point(12, 253);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new System.Drawing.Size(263, 47);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Đăng ký";
        btnRegister.UseVisualStyleBackColor = false;
        btnRegister.Click += btnRegister_Click;
        // 
        // tBCofirmPassword
        // 
        tBCofirmPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
        tBCofirmPassword.Location = new System.Drawing.Point(12, 216);
        tBCofirmPassword.Name = "tBCofirmPassword";
        tBCofirmPassword.Size = new System.Drawing.Size(263, 31);
        tBCofirmPassword.TabIndex = 5;
        tBCofirmPassword.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13F);
        label3.Location = new System.Drawing.Point(12, 185);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(263, 28);
        label3.TabIndex = 4;
        label3.Text = "Nhập lại mật khẩu";
        // 
        // tbPassword
        // 
        tbPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
        tbPassword.Location = new System.Drawing.Point(12, 151);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new System.Drawing.Size(263, 31);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 13F);
        label2.Location = new System.Drawing.Point(12, 120);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(263, 28);
        label2.TabIndex = 2;
        label2.Text = "Mật khẩu";
        // 
        // tBUsername
        // 
        tBUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
        tBUsername.Location = new System.Drawing.Point(12, 86);
        tBUsername.Name = "tBUsername";
        tBUsername.Size = new System.Drawing.Size(263, 31);
        tBUsername.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F);
        label1.Location = new System.Drawing.Point(12, 55);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(263, 28);
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
        panel1.Dock = System.Windows.Forms.DockStyle.Left;
        panel1.Location = new System.Drawing.Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(287, 450);
        panel1.TabIndex = 1;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        label5.Location = new System.Drawing.Point(12, 25);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(98, 30);
        label5.TabIndex = 9;
        label5.Text = "Đăng ký";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.SystemColors.Window;
        panel2.Controls.Add(label6);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(pictureBox1);
        panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        panel2.Location = new System.Drawing.Point(287, 0);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(513, 450);
        panel2.TabIndex = 2;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Segoe UI", 13F);
        label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        label6.Location = new System.Drawing.Point(212, 255);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(83, 25);
        label6.TabIndex = 6;
        label6.Text = "Hiệu quả";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI", 13F);
        label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        label7.Location = new System.Drawing.Point(212, 226);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(68, 25);
        label7.TabIndex = 5;
        label7.Text = "Tiện lợi";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
        label8.Location = new System.Drawing.Point(212, 185);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(213, 41);
        label8.TabIndex = 4;
        label8.Text = "Task Manager";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(6, 131);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(200, 200);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng ký";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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