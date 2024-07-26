using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class ThucDon
{
    public int MaThucdon { get; set; }

    public int? MaNhahang { get; set; }

    public string TenMon { get; set; } = null!;

    public string? Mota { get; set; }

    public decimal Gia { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual NhaHang? MaNhahangNavigation { get; set; }
}
