namespace Student_app.Main
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlBottomMenu = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnHome = new Button();
            btnCourseReg = new Button();
            btnResults = new Button();
            btnPayment = new Button();
            btnToggleMenu = new Button();
            pnlContent = new Panel();
            lblTitle = new Label();
            pbAvatar = new PictureBox();
            lblStudentId = new Label();
            lblStudentIdValue = new Label();
            lblFullName = new Label();
            lblFullNameValue = new Label();
            lblBirthDate = new Label();
            lblBirthDateValue = new Label();
            lblAddress = new Label();
            lblAddressValue = new Label();
            lblEmail = new Label();
            lblEmailValue = new Label();
            lblPhone = new Label();
            lblPhoneValue = new Label();
            lblClassCode = new Label();
            lblClassCodeValue = new Label();
            lblFaculty = new Label();
            lblFacultyValue = new Label();
            lblMajor = new Label();
            lblMajorValue = new Label();
            lblStatus = new Label();
            lblStatusValue = new Label();
            lblEnrollDate = new Label();
            lblEnrollDateValue = new Label();
            pnlMenu.SuspendLayout();
            pnlBottomMenu.SuspendLayout();
            pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(41, 128, 185);
            pnlMenu.Controls.Add(pnlBottomMenu);
            pnlMenu.Controls.Add(btnHome);
            pnlMenu.Controls.Add(btnCourseReg);
            pnlMenu.Controls.Add(btnResults);
            pnlMenu.Controls.Add(btnPayment);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(4, 5, 4, 5);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(256, 774);
            pnlMenu.TabIndex = 0;
            pnlMenu.Paint += pnlMenu_Paint;
            // 
            // pnlBottomMenu
            // 
            pnlBottomMenu.Controls.Add(btnLogout);
            pnlBottomMenu.Controls.Add(btnSettings);
            pnlBottomMenu.Dock = DockStyle.Bottom;
            pnlBottomMenu.Location = new Point(0, 595);
            pnlBottomMenu.Margin = new Padding(4, 5, 4, 5);
            pnlBottomMenu.Name = "pnlBottomMenu";
            pnlBottomMenu.Size = new Size(256, 179);
            pnlBottomMenu.TabIndex = 7;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(231, 76, 60);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 57, 43);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(207, 69, 54);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(13, 99);
            btnLogout.Margin = new Padding(4, 5, 4, 5);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(235, 69);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "🚪 Đăng Xuất";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(52, 152, 219);
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 11F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(13, 18);
            btnSettings.Margin = new Padding(4, 5, 4, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(20, 0, 0, 0);
            btnSettings.Size = new Size(235, 69);
            btnSettings.TabIndex = 0;
            btnSettings.Text = "⚙️ Cài Đặt";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(52, 152, 219);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11F);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(13, 14);
            btnHome.Margin = new Padding(4, 5, 4, 5);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(20, 0, 0, 0);
            btnHome.Size = new Size(235, 77);
            btnHome.TabIndex = 1;
            btnHome.Text = "🏠 Trang Chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnCourseReg
            // 
            btnCourseReg.BackColor = Color.FromArgb(52, 152, 219);
            btnCourseReg.Cursor = Cursors.Hand;
            btnCourseReg.FlatAppearance.BorderSize = 0;
            btnCourseReg.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            btnCourseReg.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnCourseReg.FlatStyle = FlatStyle.Flat;
            btnCourseReg.Font = new Font("Segoe UI", 11F);
            btnCourseReg.ForeColor = Color.White;
            btnCourseReg.Location = new Point(13, 101);
            btnCourseReg.Margin = new Padding(4, 5, 4, 5);
            btnCourseReg.Name = "btnCourseReg";
            btnCourseReg.Padding = new Padding(20, 0, 0, 0);
            btnCourseReg.Size = new Size(235, 77);
            btnCourseReg.TabIndex = 3;
            btnCourseReg.Text = "📚 Đăng Ký Học Phần";
            btnCourseReg.TextAlign = ContentAlignment.MiddleLeft;
            btnCourseReg.UseVisualStyleBackColor = false;
            btnCourseReg.Click += btnCourseReg_Click;
            // 
            // btnResults
            // 
            btnResults.BackColor = Color.FromArgb(52, 152, 219);
            btnResults.Cursor = Cursors.Hand;
            btnResults.FlatAppearance.BorderSize = 0;
            btnResults.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            btnResults.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnResults.FlatStyle = FlatStyle.Flat;
            btnResults.Font = new Font("Segoe UI", 11F);
            btnResults.ForeColor = Color.White;
            btnResults.Location = new Point(13, 188);
            btnResults.Margin = new Padding(4, 5, 4, 5);
            btnResults.Name = "btnResults";
            btnResults.Padding = new Padding(20, 0, 0, 0);
            btnResults.Size = new Size(235, 77);
            btnResults.TabIndex = 4;
            btnResults.Text = "📊 Kết Quả Học Tập";
            btnResults.TextAlign = ContentAlignment.MiddleLeft;
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnPayment
            // 
            btnPayment.BackColor = Color.FromArgb(52, 152, 219);
            btnPayment.Cursor = Cursors.Hand;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatAppearance.MouseDownBackColor = Color.FromArgb(31, 97, 141);
            btnPayment.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 128, 185);
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 11F);
            btnPayment.ForeColor = Color.White;
            btnPayment.Location = new Point(13, 275);
            btnPayment.Margin = new Padding(4, 5, 4, 5);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(20, 0, 0, 0);
            btnPayment.Size = new Size(235, 77);
            btnPayment.TabIndex = 5;
            btnPayment.Text = "💳 Thanh Toán Học Phí";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.UseVisualStyleBackColor = false;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnToggleMenu
            // 
            btnToggleMenu.BackColor = Color.FromArgb(52, 152, 219);
            btnToggleMenu.Cursor = Cursors.Hand;
            btnToggleMenu.FlatAppearance.BorderSize = 0;
            btnToggleMenu.FlatStyle = FlatStyle.Flat;
            btnToggleMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnToggleMenu.ForeColor = Color.White;
            btnToggleMenu.Location = new Point(0, 19);
            btnToggleMenu.Margin = new Padding(4, 5, 4, 5);
            btnToggleMenu.Name = "btnToggleMenu";
            btnToggleMenu.Size = new Size(67, 62);
            btnToggleMenu.TabIndex = 6;
            btnToggleMenu.Text = "☰";
            btnToggleMenu.UseVisualStyleBackColor = false;
            btnToggleMenu.Click += btnToggleMenu_Click;
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Controls.Add(btnToggleMenu);
            pnlContent.Controls.Add(pbAvatar);
            pnlContent.Controls.Add(lblStudentId);
            pnlContent.Controls.Add(lblStudentIdValue);
            pnlContent.Controls.Add(lblFullName);
            pnlContent.Controls.Add(lblFullNameValue);
            pnlContent.Controls.Add(lblBirthDate);
            pnlContent.Controls.Add(lblBirthDateValue);
            pnlContent.Controls.Add(lblAddress);
            pnlContent.Controls.Add(lblAddressValue);
            pnlContent.Controls.Add(lblEmail);
            pnlContent.Controls.Add(lblEmailValue);
            pnlContent.Controls.Add(lblPhone);
            pnlContent.Controls.Add(lblPhoneValue);
            pnlContent.Controls.Add(lblClassCode);
            pnlContent.Controls.Add(lblClassCodeValue);
            pnlContent.Controls.Add(lblFaculty);
            pnlContent.Controls.Add(lblFacultyValue);
            pnlContent.Controls.Add(lblMajor);
            pnlContent.Controls.Add(lblMajorValue);
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(lblStatusValue);
            pnlContent.Controls.Add(lblEnrollDate);
            pnlContent.Controls.Add(lblEnrollDateValue);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(256, 0);
            pnlContent.Margin = new Padding(4, 5, 4, 5);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40, 46, 40, 46);
            pnlContent.Size = new Size(1344, 774);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(116, 31);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(423, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN SINH VIÊN";
            lblTitle.Click += lblTitle_Click;
            // 
            // pbAvatar
            // 
            pbAvatar.BackColor = Color.White;
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(116, 123);
            pbAvatar.Margin = new Padding(4, 5, 4, 5);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(239, 337);
            pbAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pbAvatar.TabIndex = 1;
            pbAvatar.TabStop = false;
            // 
            // lblStudentId
            // 
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStudentId.ForeColor = Color.FromArgb(52, 73, 94);
            lblStudentId.Location = new Point(392, 123);
            lblStudentId.Margin = new Padding(4, 0, 4, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(128, 46);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Mã Sinh Viên:";
            lblStudentId.TextAlign = ContentAlignment.MiddleLeft;
            lblStudentId.Click += lblStudentId_Click;
            // 
            // lblStudentIdValue
            // 
            lblStudentIdValue.BackColor = Color.Transparent;
            lblStudentIdValue.Font = new Font("Segoe UI", 10F);
            lblStudentIdValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblStudentIdValue.Location = new Point(552, 123);
            lblStudentIdValue.Margin = new Padding(4, 0, 4, 0);
            lblStudentIdValue.Name = "lblStudentIdValue";
            lblStudentIdValue.Padding = new Padding(7, 8, 7, 8);
            lblStudentIdValue.Size = new Size(211, 46);
            lblStudentIdValue.TabIndex = 3;
            lblStudentIdValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(52, 73, 94);
            lblFullName.Location = new Point(790, 123);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(103, 46);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Họ và Tên:";
            lblFullName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFullNameValue
            // 
            lblFullNameValue.BackColor = Color.Transparent;
            lblFullNameValue.Font = new Font("Segoe UI", 10F);
            lblFullNameValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblFullNameValue.Location = new Point(901, 123);
            lblFullNameValue.Margin = new Padding(4, 0, 4, 0);
            lblFullNameValue.Name = "lblFullNameValue";
            lblFullNameValue.Padding = new Padding(7, 8, 7, 8);
            lblFullNameValue.Size = new Size(361, 46);
            lblFullNameValue.TabIndex = 5;
            lblFullNameValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirthDate
            // 
            lblBirthDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBirthDate.ForeColor = Color.FromArgb(52, 73, 94);
            lblBirthDate.Location = new Point(392, 192);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(128, 46);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Ngày Sinh:";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBirthDateValue
            // 
            lblBirthDateValue.BackColor = Color.Transparent;
            lblBirthDateValue.Font = new Font("Segoe UI", 10F);
            lblBirthDateValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblBirthDateValue.Location = new Point(515, 192);
            lblBirthDateValue.Margin = new Padding(4, 0, 4, 0);
            lblBirthDateValue.Name = "lblBirthDateValue";
            lblBirthDateValue.Padding = new Padding(7, 8, 7, 8);
            lblBirthDateValue.Size = new Size(248, 46);
            lblBirthDateValue.TabIndex = 7;
            lblBirthDateValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddress.ForeColor = Color.FromArgb(52, 73, 94);
            lblAddress.Location = new Point(392, 264);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(128, 46);
            lblAddress.TabIndex = 8;
            lblAddress.Text = "Địa Chỉ:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddressValue
            // 
            lblAddressValue.BackColor = Color.Transparent;
            lblAddressValue.Font = new Font("Segoe UI", 10F);
            lblAddressValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblAddressValue.Location = new Point(495, 264);
            lblAddressValue.Margin = new Padding(4, 0, 4, 0);
            lblAddressValue.Name = "lblAddressValue";
            lblAddressValue.Padding = new Padding(7, 8, 7, 8);
            lblAddressValue.Size = new Size(767, 46);
            lblAddressValue.TabIndex = 9;
            lblAddressValue.TextAlign = ContentAlignment.MiddleLeft;
            lblAddressValue.Click += lblAddressValue_Click;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(52, 73, 94);
            lblEmail.Location = new Point(392, 335);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 46);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            lblEmail.Click += lblEmail_Click;
            // 
            // lblEmailValue
            // 
            lblEmailValue.BackColor = Color.Transparent;
            lblEmailValue.Font = new Font("Segoe UI", 10F);
            lblEmailValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblEmailValue.Location = new Point(495, 335);
            lblEmailValue.Margin = new Padding(4, 0, 4, 0);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Padding = new Padding(7, 8, 7, 8);
            lblEmailValue.Size = new Size(767, 46);
            lblEmailValue.TabIndex = 11;
            lblEmailValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(52, 73, 94);
            lblPhone.Location = new Point(790, 192);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(163, 46);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "Số Điện Thoại:";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhoneValue
            // 
            lblPhoneValue.BackColor = Color.Transparent;
            lblPhoneValue.Font = new Font("Segoe UI", 10F);
            lblPhoneValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblPhoneValue.Location = new Point(938, 192);
            lblPhoneValue.Margin = new Padding(4, 0, 4, 0);
            lblPhoneValue.Name = "lblPhoneValue";
            lblPhoneValue.Padding = new Padding(7, 8, 7, 8);
            lblPhoneValue.Size = new Size(324, 46);
            lblPhoneValue.TabIndex = 13;
            lblPhoneValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblClassCode
            // 
            lblClassCode.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClassCode.ForeColor = Color.FromArgb(52, 73, 94);
            lblClassCode.Location = new Point(392, 414);
            lblClassCode.Margin = new Padding(4, 0, 4, 0);
            lblClassCode.Name = "lblClassCode";
            lblClassCode.Size = new Size(96, 46);
            lblClassCode.TabIndex = 14;
            lblClassCode.Text = "Mã Lớp:";
            lblClassCode.TextAlign = ContentAlignment.MiddleLeft;
            lblClassCode.Click += lblClassCode_Click;
            // 
            // lblClassCodeValue
            // 
            lblClassCodeValue.BackColor = Color.Transparent;
            lblClassCodeValue.Font = new Font("Segoe UI", 10F);
            lblClassCodeValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblClassCodeValue.Location = new Point(542, 414);
            lblClassCodeValue.Margin = new Padding(4, 0, 4, 0);
            lblClassCodeValue.Name = "lblClassCodeValue";
            lblClassCodeValue.Padding = new Padding(7, 8, 7, 8);
            lblClassCodeValue.Size = new Size(221, 46);
            lblClassCodeValue.TabIndex = 15;
            lblClassCodeValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFaculty
            // 
            lblFaculty.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFaculty.ForeColor = Color.FromArgb(52, 73, 94);
            lblFaculty.Location = new Point(790, 414);
            lblFaculty.Margin = new Padding(4, 0, 4, 0);
            lblFaculty.Name = "lblFaculty";
            lblFaculty.Size = new Size(96, 46);
            lblFaculty.TabIndex = 18;
            lblFaculty.Text = "Khoa:";
            lblFaculty.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFacultyValue
            // 
            lblFacultyValue.BackColor = Color.Transparent;
            lblFacultyValue.Font = new Font("Segoe UI", 10F);
            lblFacultyValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblFacultyValue.Location = new Point(916, 414);
            lblFacultyValue.Margin = new Padding(4, 0, 4, 0);
            lblFacultyValue.Name = "lblFacultyValue";
            lblFacultyValue.Padding = new Padding(7, 8, 7, 8);
            lblFacultyValue.Size = new Size(346, 46);
            lblFacultyValue.TabIndex = 19;
            lblFacultyValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMajor
            // 
            lblMajor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMajor.ForeColor = Color.FromArgb(52, 73, 94);
            lblMajor.Location = new Point(392, 499);
            lblMajor.Margin = new Padding(4, 0, 4, 0);
            lblMajor.Name = "lblMajor";
            lblMajor.Size = new Size(162, 46);
            lblMajor.TabIndex = 20;
            lblMajor.Text = "Chuyên Ngành:";
            lblMajor.TextAlign = ContentAlignment.MiddleLeft;
            lblMajor.Click += lblMajor_Click;
            // 
            // lblMajorValue
            // 
            lblMajorValue.BackColor = Color.Transparent;
            lblMajorValue.Font = new Font("Segoe UI", 10F);
            lblMajorValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblMajorValue.Location = new Point(584, 499);
            lblMajorValue.Margin = new Padding(4, 0, 4, 0);
            lblMajorValue.Name = "lblMajorValue";
            lblMajorValue.Padding = new Padding(7, 8, 7, 8);
            lblMajorValue.Size = new Size(678, 46);
            lblMajorValue.TabIndex = 21;
            lblMajorValue.TextAlign = ContentAlignment.MiddleLeft;
            lblMajorValue.Click += lblMajorValue_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(52, 73, 94);
            lblStatus.Location = new Point(392, 599);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 46);
            lblStatus.TabIndex = 22;
            lblStatus.Text = "Trạng Thái:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatusValue
            // 
            lblStatusValue.BackColor = Color.Transparent;
            lblStatusValue.Font = new Font("Segoe UI", 10F);
            lblStatusValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblStatusValue.Location = new Point(542, 599);
            lblStatusValue.Margin = new Padding(4, 0, 4, 0);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Padding = new Padding(7, 8, 7, 8);
            lblStatusValue.Size = new Size(221, 46);
            lblStatusValue.TabIndex = 23;
            lblStatusValue.TextAlign = ContentAlignment.MiddleLeft;
            lblStatusValue.Click += lblStatusValue_Click;
            // 
            // lblEnrollDate
            // 
            lblEnrollDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEnrollDate.ForeColor = Color.FromArgb(52, 73, 94);
            lblEnrollDate.Location = new Point(790, 599);
            lblEnrollDate.Margin = new Padding(4, 0, 4, 0);
            lblEnrollDate.Name = "lblEnrollDate";
            lblEnrollDate.Size = new Size(200, 46);
            lblEnrollDate.TabIndex = 24;
            lblEnrollDate.Text = "Ngày Nhập Học:";
            lblEnrollDate.TextAlign = ContentAlignment.MiddleLeft;
            lblEnrollDate.Click += lblEnrollDate_Click;
            // 
            // lblEnrollDateValue
            // 
            lblEnrollDateValue.BackColor = Color.Transparent;
            lblEnrollDateValue.Font = new Font("Segoe UI", 10F);
            lblEnrollDateValue.ForeColor = Color.FromArgb(44, 62, 80);
            lblEnrollDateValue.Location = new Point(957, 599);
            lblEnrollDateValue.Margin = new Padding(4, 0, 4, 0);
            lblEnrollDateValue.Name = "lblEnrollDateValue";
            lblEnrollDateValue.Padding = new Padding(7, 8, 7, 8);
            lblEnrollDateValue.Size = new Size(305, 46);
            lblEnrollDateValue.TabIndex = 25;
            lblEnrollDateValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 242, 245);
            ClientSize = new Size(1600, 774);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản Lý Sinh Viên";
            pnlMenu.ResumeLayout(false);
            pnlBottomMenu.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlBottomMenu;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCourseReg;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblStudentIdValue;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblBirthDateValue;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblClassCode;
        private System.Windows.Forms.Label lblClassCodeValue;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblFacultyValue;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblMajorValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblEnrollDate;
        private System.Windows.Forms.Label lblEnrollDateValue;
    }
}