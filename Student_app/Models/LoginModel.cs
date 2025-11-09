using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_app.Models
{
    public class LoginRequest
    {
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }
    }

    public class LoginResponse
    {
        public string StudentId { get; set; }
        public string AccountType { get; set; }
        public string accountStatus { get; set; }
    }
}
