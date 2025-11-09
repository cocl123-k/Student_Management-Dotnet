using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblSinhVien
{
    public string MaSv { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string GioiTinh { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? Email { get; set; }

    public string? SoDienThoai { get; set; }

    public string? MaLop { get; set; }

    public string? TrangThai { get; set; }

    public DateOnly? NgayNhapHoc { get; set; }

    public virtual TblLop? MaLopNavigation { get; set; }

    public virtual ICollection<TblDangKyHocPhan> TblDangKyHocPhans { get; set; } = new List<TblDangKyHocPhan>();

    public virtual ICollection<TblDiem> TblDiems { get; set; } = new List<TblDiem>();

    public virtual ICollection<TblTaiKhoan> TblTaiKhoans { get; set; } = new List<TblTaiKhoan>();
}
