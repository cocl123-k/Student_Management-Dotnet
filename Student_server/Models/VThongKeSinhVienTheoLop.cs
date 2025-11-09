using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class VThongKeSinhVienTheoLop
{
    public string MaLop { get; set; } = null!;

    public string TenLop { get; set; } = null!;

    public string? Khoa { get; set; }

    public string? NienKhoa { get; set; }

    public int? SoLuongSinhVien { get; set; }

    public int? SoNam { get; set; }

    public int? SoNu { get; set; }
}
