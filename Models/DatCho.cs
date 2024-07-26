using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class DatCho
{
    public int MaDatcho { get; set; }

    public int? MaNguoidung { get; set; }

    public int? MaNhahang { get; set; }

    public int? MaBan { get; set; }

    public DateOnly NgayDatcho { get; set; }

    public TimeOnly GioDatcho { get; set; }

    public int? SoNguoi { get; set; }

    public string? Trangthai { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public string? Dichvukhac { get; set; }

    public virtual ICollection<Khuyenmai> Khuyenmais { get; set; } = new List<Khuyenmai>();

    public virtual Ban? MaBanNavigation { get; set; }

    public virtual NguoiDung? MaNguoidungNavigation { get; set; }

    public virtual NhaHang? MaNhahangNavigation { get; set; }

    public virtual ICollection<ThanhToan> ThanhToans { get; set; } = new List<ThanhToan>();
}
