using Student_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_app.Main
{
    public partial class Home : Form
    {
        private bool isMenuExpanded = true;
        private int MenuExpandedWidth;
        private const int MenuCollapsedWidth = 0;
        private readonly LoginResponse _loginData;

        public Home(LoginResponse loginResponse)
        {
            InitializeComponent();
            MenuExpandedWidth = pnlMenu.Width;
            _loginData = loginResponse;
            LoadStudentInfo();
        }

        private void LoadStudentInfo()
        {
            // Load dữ liệu mẫu cho sinh viên
            lblStudentIdValue.Text = _loginData.StudentId;

            // Tạo ảnh đại diện mẫu
            CreateAvatarPlaceholder();
        }

        private void CreateAvatarPlaceholder()
        {
            try
            {
                Bitmap bmp = new Bitmap(180, 220);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.FromArgb(52, 152, 219));
                    using (Font font = new Font("Segoe UI", 24, FontStyle.Bold))
                    {
                        string initials = "NVA";
                        SizeF size = g.MeasureString(initials, font);
                        g.DrawString(initials, font, Brushes.White,
                            (180 - size.Width) / 2, (220 - size.Height) / 2);
                    }
                }
                pbAvatar.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải ảnh: " + ex.Message);
            }
        }

        // Toggle menu
        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            isMenuExpanded = !isMenuExpanded;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            int targetWidth = isMenuExpanded ? MenuExpandedWidth : MenuCollapsedWidth;
            int step = isMenuExpanded ? 10 : -10;

            timer.Tick += (s, ev) =>
            {
                if ((isMenuExpanded && pnlMenu.Width < targetWidth) ||
                    (!isMenuExpanded && pnlMenu.Width > targetWidth))
                {
                    pnlMenu.Width += step;
                }
                else
                {
                    pnlMenu.Width = targetWidth;
                    timer.Stop();
                    UpdateMenuButtonsText();

                    btnToggleMenu.BringToFront();
                }
            };
            timer.Start();
        }

        private void UpdateMenuButtonsText()
        {
            if (isMenuExpanded)
            {
                pnlBottomMenu.Visible = true;
                btnHome.Visible = true;
                btnCourseReg.Visible = true;
                btnResults.Visible = true;
                btnPayment.Visible = true;
                btnHome.Text = "🏠 Trang Chủ";
                btnCourseReg.Text = "📚 Đăng Ký Học Phần";
                btnResults.Text = "📊 Kết Quả Học Tập";
                btnPayment.Text = "💳 Thanh Toán Học Phí";
                btnSettings.Text = "⚙️ Cài Đặt";
                lblLogo.Visible = true;
            }
            else
            {
                lblLogo.Visible = false;
                pnlBottomMenu.Visible = false;
                btnHome.Visible = false;
                btnCourseReg.Visible = false;
                btnResults.Visible = false;
                btnPayment.Visible = false;
            }
        }

        // Event handlers cho menu buttons
        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang chủ", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Cài Đặt Tài Khoản", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCourseReg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Đăng Ký Học Phần", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Kết Quả Học Tập", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Thanh Toán Học Phí", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Đăng xuất thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Application.Exit();
            }
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentId_Click(object sender, EventArgs e)
        {

        }

        private void lblAddressValue_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblClassCode_Click(object sender, EventArgs e)
        {

        }

        private void lblClassValue_Click(object sender, EventArgs e)
        {

        }

        private void lblMajor_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblMajorValue_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusValue_Click(object sender, EventArgs e)
        {

        }

        private void lblEnrollDate_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
