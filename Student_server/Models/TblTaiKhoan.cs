using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Studen_server.Models;

public partial class TblTaiKhoan
{
    public int Id { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string LoaiTaiKhoan { get; set; } = null!;

    public string? MaSv { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? LanDangNhapCuoi { get; set; }

    public string? TrangThai { get; set; }

    public virtual TblSinhVien? MaSvNavigation { get; set; }
}

public class LoginRequest
{
    [Required]
    public string? TenDangNhap { get; set; }

    [Required]
    public string? MatKhau { get; set; }
}
