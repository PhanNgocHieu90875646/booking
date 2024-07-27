using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class Ban
{
    public int MaBan { get; set; }

    public int? MaNhahang { get; set; }

    public string? SoBan { get; set; }

    public int? SucChua { get; set; }

    public string? Mota { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public DateTime? GioBatdau { get; set; }

    public DateTime? GioKetthuc { get; set; }

    public string? Trangthai { get; set; }

    public virtual ICollection<DatCho> DatChos { get; set; } = new List<DatCho>();

    public virtual NhaHang? MaNhahangNavigation { get; set; }
}
