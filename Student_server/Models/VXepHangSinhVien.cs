using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class VXepHangSinhVien
{
    public string MaSv { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string? TenLop { get; set; }

    public int? SoMonDaHoc { get; set; }

    public decimal? DiemTrungBinh { get; set; }

    public int? TongTinChiDat { get; set; }

    public long? XepHangTrongLop { get; set; }
}
