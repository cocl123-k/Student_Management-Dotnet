using Student_app.Main;
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
using static System.Net.WebRequestMethods;

namespace Student_app.Login
{
    public partial class Login : Form
    {
        private readonly ApiService _apiService;
        public Login()
        {
            InitializeComponent();
            _apiService = new ApiService();
            SetupEvents();
        }
        private void SetupEvents()
        {
            btnLogin.Click += async (s, e) => await BtnLogin_click(s, e);
        }

        public LoginResponse SuccessfulLoginData { get; private set; }

        private async Task BtnLogin_click(object sender, EventArgs eventArgs)
        {
            string username = txtUsername.Text.Trim();
            string passsword = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passsword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "ĐANG ĐĂNG NHẬP...";

            try
            {
                var loginResponse = await _apiService.LoginAsync(username, passsword);

                if (loginResponse != null)
                {
                    this.SuccessfulLoginData = loginResponse; // 1. Lưu dữ liệu
                    this.DialogResult = DialogResult.OK;      // 2. Báo là "Thành công"
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                        "Lỗi đăng nhập",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "ĐĂNG NHẬP";
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword(_apiService);
            DialogResult result = forgotForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Mật khẩu đã được đặt lại thành công. Vui lòng đăng nhập lại.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
