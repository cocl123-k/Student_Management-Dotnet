using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class VThongKeKetQuaTheoMon
{
    public string MaMonHoc { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;

    public string TenHocKy { get; set; } = null!;

    public string NamHoc { get; set; } = null!;

    public int? TongSoSinhVien { get; set; }

    public int? SoSinhVienDat { get; set; }

    public int? SoSinhVienKhongDat { get; set; }

    public decimal? DiemTrungBinh { get; set; }

    public double? TyLeDat { get; set; }
}
