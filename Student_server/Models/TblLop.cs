using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblLop
{
    public string MaLop { get; set; } = null!;

    public string TenLop { get; set; } = null!;

    public string? Khoa { get; set; }

    public string? NienKhoa { get; set; }

    public virtual ICollection<TblSinhVien> TblSinhViens { get; set; } = new List<TblSinhVien>();
}
