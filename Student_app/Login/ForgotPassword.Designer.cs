namespace Student_app.Login
{
    partial class ForgotPassword
    {
        private System.ComponentModel.IContainer components = null;

        private Panel mainPanel;
        private Label lblIcon;
        private Label lblTitle;
        private Label lblDescription;

        // Step 1 - Email
        private Label lblEmail;
        private TextBox txtEmail;

        // Step 2 - Verify Code
        private Label lblVerifyCode;
        private TextBox txtVerifyCode;
        private LinkLabel btnResend;

        // Step 3 - New Password
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;

        private Button btnNext;
        private Button btnBack;

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
            lblIcon = new Label();
            lblTitle = new Label();
            lblDescription = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblVerifyCode = new Label();
            txtVerifyCode = new TextBox();
            btnResend = new LinkLabel();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnNext = new Button();
            btnBack = new Button();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(lblIcon);
            mainPanel.Controls.Add(lblTitle);
            mainPanel.Controls.Add(lblDescription);
            mainPanel.Controls.Add(lblEmail);
            mainPanel.Controls.Add(txtEmail);
            mainPanel.Controls.Add(lblVerifyCode);
            mainPanel.Controls.Add(txtVerifyCode);
            mainPanel.Controls.Add(btnResend);
            mainPanel.Controls.Add(lblNewPassword);
            mainPanel.Controls.Add(txtNewPassword);
            mainPanel.Controls.Add(lblConfirmPassword);
            mainPanel.Controls.Add(txtConfirmPassword);
            mainPanel.Controls.Add(btnNext);
            mainPanel.Controls.Add(btnBack);
            mainPanel.Location = new Point(29, 47);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(400, 667);
            mainPanel.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.Font = new Font("Segoe UI", 42F);
            lblIcon.Location = new Point(143, 33);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(114, 93);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "🔑";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 98, 255);
            lblTitle.Location = new Point(29, 133);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(343, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QUÊN MẬT KHẨU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(120, 120, 120);
            lblDescription.Location = new Point(29, 187);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(343, 53);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Nhập email để nhận mã xác thực";
            lblDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(100, 100, 100);
            lblEmail.Location = new Point(29, 260);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(343, 33);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(248, 249, 250);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(29, 293);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@student.edu.vn";
            txtEmail.Size = new Size(343, 32);
            txtEmail.TabIndex = 0;
            // 
            // lblVerifyCode
            // 
            lblVerifyCode.Font = new Font("Segoe UI", 10F);
            lblVerifyCode.ForeColor = Color.FromArgb(100, 100, 100);
            lblVerifyCode.Location = new Point(29, 260);
            lblVerifyCode.Name = "lblVerifyCode";
            lblVerifyCode.Size = new Size(343, 33);
            lblVerifyCode.TabIndex = 5;
            lblVerifyCode.Text = "Mã xác thực";
            lblVerifyCode.Visible = false;
            // 
            // txtVerifyCode
            // 
            txtVerifyCode.BackColor = Color.FromArgb(248, 249, 250);
            txtVerifyCode.BorderStyle = BorderStyle.FixedSingle;
            txtVerifyCode.Font = new Font("Segoe UI", 11F);
            txtVerifyCode.Location = new Point(29, 293);
            txtVerifyCode.Margin = new Padding(3, 4, 3, 4);
            txtVerifyCode.MaxLength = 6;
            txtVerifyCode.Name = "txtVerifyCode";
            txtVerifyCode.PlaceholderText = "Nhập mã 6 số";
            txtVerifyCode.Size = new Size(343, 32);
            txtVerifyCode.TabIndex = 0;
            txtVerifyCode.TextAlign = HorizontalAlignment.Center;
            txtVerifyCode.Visible = false;
            // 
            // btnResend
            // 
            btnResend.Font = new Font("Segoe UI", 9F);
            btnResend.LinkBehavior = LinkBehavior.HoverUnderline;
            btnResend.LinkColor = Color.FromArgb(41, 98, 255);
            btnResend.Location = new Point(29, 347);
            btnResend.Name = "btnResend";
            btnResend.Size = new Size(343, 33);
            btnResend.TabIndex = 7;
            btnResend.TabStop = true;
            btnResend.Text = "Gửi lại mã xác thực";
            btnResend.TextAlign = ContentAlignment.MiddleCenter;
            btnResend.Visible = false;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Segoe UI", 10F);
            lblNewPassword.ForeColor = Color.FromArgb(100, 100, 100);
            lblNewPassword.Location = new Point(29, 260);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(343, 33);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "Mật khẩu mới";
            lblNewPassword.Visible = false;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtNewPassword.BorderStyle = BorderStyle.FixedSingle;
            txtNewPassword.Font = new Font("Segoe UI", 11F);
            txtNewPassword.Location = new Point(29, 293);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(343, 32);
            txtNewPassword.TabIndex = 0;
            txtNewPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.ForeColor = Color.FromArgb(100, 100, 100);
            lblConfirmPassword.Location = new Point(29, 353);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(343, 33);
            lblConfirmPassword.TabIndex = 10;
            lblConfirmPassword.Text = "Xác nhận mật khẩu";
            lblConfirmPassword.Visible = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.FromArgb(248, 249, 250);
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new Point(29, 387);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.Size = new Size(343, 32);
            txtConfirmPassword.TabIndex = 1;
            txtConfirmPassword.Visible = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(41, 98, 255);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(29, 507);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(343, 60);
            btnNext.TabIndex = 2;
            btnNext.Text = "GỬI MÃ XÁC THỰC";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(41, 98, 255);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F);
            btnBack.ForeColor = Color.FromArgb(41, 98, 255);
            btnBack.Location = new Point(29, 580);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(343, 53);
            btnBack.TabIndex = 3;
            btnBack.Text = "← Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(457, 760);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên mật khẩu";
            Load += ForgotPassword_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}