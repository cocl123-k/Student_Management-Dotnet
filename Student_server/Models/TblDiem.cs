using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblDiem
{
    public int Id { get; set; }

    public string MaSv { get; set; } = null!;

    public string MaLopHp { get; set; } = null!;

    public decimal? DiemChuyenCan { get; set; }

    public decimal? DiemGiuaKy { get; set; }

    public decimal? DiemCuoiKy { get; set; }

    public decimal? DiemTongKet { get; set; }

    public string? DiemChu { get; set; }

    public string KetQua { get; set; } = null!;

    public string? GhiChu { get; set; }

    public DateTime? NgayCapNhat { get; set; }

    public virtual TblLopHocPhan MaLopHpNavigation { get; set; } = null!;

    public virtual TblSinhVien MaSvNavigation { get; set; } = null!;
}
