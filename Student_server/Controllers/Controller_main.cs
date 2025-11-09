using Azure.Core;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studen_server.Data;
using Studen_server.Models;

namespace Studen_server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller_main : ControllerBase
    {
        private readonly StudentDbContext _context;

        public Controller_main(StudentDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Models.LoginRequest loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.TenDangNhap) || string.IsNullOrEmpty(loginRequest.MatKhau))
            {
                return BadRequest(new { message = "Thiếu tên đăng nhập hoặc mật khẩu" });
            }

            var user = await _context.TblTaiKhoans
                .FirstOrDefaultAsync(u => u.TenDangNhap == loginRequest.TenDangNhap && u.MatKhau == loginRequest.MatKhau);

            if (user == null)
            {
                return Unauthorized(new { message = "Tên đăng nhập hoặc mật khẩu không đúng" });
            }

            if (user.TrangThai == "Khóa")
            {
                return Unauthorized(new { message = "Tài khoản đã bị khóa" });
            }

            return Ok(new
            {
                studentId = user.MaSv,
                accountType = user.LoaiTaiKhoan,
                accountStatus = user.TrangThai
            });
        }

        
    }
}
