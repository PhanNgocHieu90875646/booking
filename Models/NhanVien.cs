using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class NhanVien
{
    public int MaNhanvien { get; set; }

    public int? MaNhahang { get; set; }

    public string TenNhanvien { get; set; } = null!;

    public string? ChucVu { get; set; }

    public string? Email { get; set; }

    public string? Sdt { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual NhaHang? MaNhahangNavigation { get; set; }
}
