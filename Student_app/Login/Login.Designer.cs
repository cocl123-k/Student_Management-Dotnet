namespace Student_app.Login
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các controls
        private Panel mainPanel;
        private Label lblLogo;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkRemember;
        private Button btnLogin;
        private LinkLabel lnkForgot;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            lblLogo = new Label();
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkRemember = new CheckBox();
            btnLogin = new Button();
            lnkForgot = new LinkLabel();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(lblLogo);
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(lblUsername);
            mainPanel.Controls.Add(txtUsername);
            mainPanel.Controls.Add(lblPassword);
            mainPanel.Controls.Add(txtPassword);
            mainPanel.Controls.Add(chkRemember);
            mainPanel.Controls.Add(btnLogin);
            mainPanel.Controls.Add(lnkForgot);
            mainPanel.Location = new Point(29, 47);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(400, 640);
            mainPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Font = new Font("Segoe UI", 48F);
            lblLogo.Location = new Point(143, 40);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(114, 107);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🎓";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 98, 255);
            lblTitle.Location = new Point(29, 147);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 53);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "STUDENT APP";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(100, 100, 100);
            lblUsername.Location = new Point(29, 227);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(343, 33);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(248, 249, 250);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(29, 260);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(343, 32);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.ForeColor = Color.FromArgb(100, 100, 100);
            lblPassword.Location = new Point(29, 327);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(343, 33);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(29, 360);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(343, 32);
            txtPassword.TabIndex = 1;
            // 
            // chkRemember
            // 
            chkRemember.Font = new Font("Segoe UI", 9F);
            chkRemember.ForeColor = Color.FromArgb(100, 100, 100);
            chkRemember.Location = new Point(29, 427);
            chkRemember.Margin = new Padding(3, 4, 3, 4);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(171, 33);
            chkRemember.TabIndex = 2;
            chkRemember.Text = "Ghi nhớ đăng nhập";
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 98, 255);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(29, 487);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 60);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkForgot
            // 
            lnkForgot.Font = new Font("Segoe UI", 9F);
            lnkForgot.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkForgot.LinkColor = Color.FromArgb(41, 98, 255);
            lnkForgot.Location = new Point(29, 560);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(343, 33);
            lnkForgot.TabIndex = 4;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Quên mật khẩu?";
            lnkForgot.TextAlign = ContentAlignment.MiddleCenter;
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(457, 733);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student App - Đăng nhập";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}