using System;
using System.Collections.Generic;

namespace booking.Models;

public partial class NguoiDung
{
    public int MaNguoidung { get; set; }

    public string TenDangnhap { get; set; } = null!;

    public string Matkhau { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Sdt { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayCapnhat { get; set; }

    public virtual ICollection<DanhGium> DanhGia { get; set; } = new List<DanhGium>();

    public virtual ICollection<DatCho> DatChos { get; set; } = new List<DatCho>();
}
