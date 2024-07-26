using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class Khuyenmai
{
    public string MaKhuyenmai { get; set; } = null!;

    public int? MaDatcho { get; set; }

    public string TenKhuyenmai { get; set; } = null!;

    public string? Mota { get; set; }

    public DateTime? Ngbatdau { get; set; }

    public DateTime? Ngkettuc { get; set; }

    public string? Loaikhuyenmai { get; set; }

    public int? Giatri { get; set; }

    public string? Trangthai { get; set; }

    public virtual DatCho? MaDatchoNavigation { get; set; }
}
