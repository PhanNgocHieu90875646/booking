using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class DanhMucNhaHang
{
    public int? MaNhahang { get; set; }

    public int? MaDanhmuc { get; set; }

    public string? Mota { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual NhaHang? MaNhahangNavigation { get; set; }
}
