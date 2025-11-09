using System;
using System.Collections.Generic;

namespace Studen_server.Models;

public partial class TblMonHoc
{
    public string MaMonHoc { get; set; } = null!;

    public string TenMonHoc { get; set; } = null!;

    public int SoTinChi { get; set; }

    public string? MonHocTienQuyet { get; set; }

    public string? MoTa { get; set; }

    public virtual ICollection<TblMonHoc> InverseMonHocTienQuyetNavigation { get; set; } = new List<TblMonHoc>();

    public virtual TblMonHoc? MonHocTienQuyetNavigation { get; set; }

    public virtual ICollection<TblLopHocPhan> TblLopHocPhans { get; set; } = new List<TblLopHocPhan>();
}
