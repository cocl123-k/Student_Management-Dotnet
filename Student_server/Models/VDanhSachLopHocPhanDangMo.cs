using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class VDanhSachLopHocPhanDangMo
{
    public string MaLopHp { get; set; } = null!;

    public string TenLopHp { get; set; } = null!;

    public string MaMonHoc { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;

    public int SoTinChi { get; set; }

    public string TenHocKy { get; set; } = null!;

    public string NamHoc { get; set; } = null!;

    public string? GiangVien { get; set; }

    public string? LichHoc { get; set; }

    public string? PhongHoc { get; set; }

    public int? SoChoToiDa { get; set; }

    public int? SoSinhVienDaDk { get; set; }

    public int? SoChoConLai { get; set; }
}
