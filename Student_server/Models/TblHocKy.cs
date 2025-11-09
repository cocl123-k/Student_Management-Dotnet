using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblHocKy
{
    public string MaHocKy { get; set; } = null!;

    public string TenHocKy { get; set; } = null!;

    public string NamHoc { get; set; } = null!;

    public DateOnly NgayBatDau { get; set; }

    public DateOnly NgayKetThuc { get; set; }

    public string? TrangThai { get; set; }

    public virtual ICollection<TblLopHocPhan> TblLopHocPhans { get; set; } = new List<TblLopHocPhan>();
}
