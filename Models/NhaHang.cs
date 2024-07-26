using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class NhaHang
{
    public int MaNhahang { get; set; }

    public string Ten { get; set; } = null!;

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }

    public string? Mota { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<DatCho> DatChos { get; set; } = new List<DatCho>();

    public virtual ICollection<NhanVien> NhanViens { get; set; } = new List<NhanVien>();

    public virtual ICollection<ThucDon> ThucDons { get; set; } = new List<ThucDon>();
}
