using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblLopHocPhan
{
    public string MaLopHp { get; set; } = null!;

    public string MaMonHoc { get; set; } = null!;

    public string MaHocKy { get; set; } = null!;

    public string TenLopHp { get; set; } = null!;

    public string? GiangVien { get; set; }

    public int? SoChoToiDa { get; set; }

    public int? SoSinhVienDaDk { get; set; }

    public string? LichHoc { get; set; }

    public string? PhongHoc { get; set; }

    public virtual TblHocKy MaHocKyNavigation { get; set; } = null!;

    public virtual TblMonHoc MaMonHocNavigation { get; set; } = null!;

    public virtual ICollection<TblDangKyHocPhan> TblDangKyHocPhans { get; set; } = new List<TblDangKyHocPhan>();

    public virtual ICollection<TblDiem> TblDiems { get; set; } = new List<TblDiem>();
}
