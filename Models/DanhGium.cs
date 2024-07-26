using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class DanhGium
{
    public int MaDanhgia { get; set; }

    public int? MaNguoidung { get; set; }

    public int? MaNhahang { get; set; }

    public int? Danhgia { get; set; }

    public string? Binhluan { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual NguoiDung? MaNguoidungNavigation { get; set; }

    public virtual NhaHang? MaNhahangNavigation { get; set; }
}
