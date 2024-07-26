using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class ThanhToan
{
    public int MaThanhtoan { get; set; }

    public int? MaDatcho { get; set; }

    public decimal Sotien { get; set; }

    public string? PhuongthucThanhtoan { get; set; }

    public string? TrangthaiThanhtoan { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual DatCho? MaDatchoNavigation { get; set; }
}
