 using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblDangKyHocPhan
{
    public int Id { get; set; }

    public string MaSv { get; set; } = null!;

    public string MaLopHp { get; set; } = null!;

    public DateTime? NgayDangKy { get; set; }

    public string? TrangThaiDangKy { get; set; }

    public virtual TblLopHocPhan MaLopHpNavigation { get; set; } = null!;

    public virtual TblSinhVien MaSvNavigation { get; set; } = null!;
}
