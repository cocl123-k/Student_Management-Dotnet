using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_app.Login
{
    public partial class ForgotPassword : Form
    {
        private readonly ApiService _apiService;
        public ForgotPassword(ApiService apiService)
        {
            InitializeComponent();

            _apiService = apiService;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }
    }
}
