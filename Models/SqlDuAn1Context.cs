using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace booking.Models;

public partial class SqlDuAn1Context : DbContext
{
    public SqlDuAn1Context()
    {
    }

    public SqlDuAn1Context(DbContextOptions<SqlDuAn1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<DanhGium> DanhGia { get; set; }

    public virtual DbSet<DanhMucNhaHang> DanhMucNhaHangs { get; set; }

    public virtual DbSet<DatCho> DatChos { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhaHang> NhaHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<ThanhToan> ThanhToans { get; set; }

    public virtual DbSet<ThucDon> ThucDons { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= HIEUPHAN\\SQLEXPRESS ;Initial Catalog= SqlDuAn1;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => e.MaBan).HasName("PK__Ban__03FFDF0D86B9785D");

            entity.ToTable("Ban");

            entity.Property(e => e.MaBan).HasColumnName("ma_ban");
            entity.Property(e => e.GioBatdau)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("gio_batdau");
            entity.Property(e => e.GioKetthuc)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("gio_ketthuc");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SoBan)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("so_ban");
            entity.Property(e => e.SucChua).HasColumnName("suc_chua");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .HasColumnName("trangthai");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany(p => p.Bans)
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__Ban__ma_nhahang__4316F928");
        });

        modelBuilder.Entity<DanhGium>(entity =>
        {
            entity.HasKey(e => e.MaDanhgia).HasName("PK__DanhGia__BFCBE0C6D0421D38");

            entity.Property(e => e.MaDanhgia).HasColumnName("ma_danhgia");
            entity.Property(e => e.Binhluan)
                .HasColumnType("text")
                .HasColumnName("binhluan");
            entity.Property(e => e.Danhgia).HasColumnName("danhgia");
            entity.Property(e => e.MaNguoidung).HasColumnName("ma_nguoidung");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");

            entity.HasOne(d => d.MaNguoidungNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.MaNguoidung)
                .HasConstraintName("FK__DanhGia__ma_nguo__59FA5E80");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany(p => p.DanhGia)
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__DanhGia__ma_nhah__5AEE82B9");
        });

        modelBuilder.Entity<DanhMucNhaHang>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DanhMuc_NhaHang");

            entity.Property(e => e.MaDanhmuc).HasColumnName("ma_danhmuc");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany()
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__DanhMuc_N__ngay___6477ECF3");
        });

        modelBuilder.Entity<DatCho>(entity =>
        {
            entity.HasKey(e => e.MaDatcho).HasName("PK__DatCho__1447197416BADD9E");

            entity.ToTable("DatCho");

            entity.Property(e => e.MaDatcho).HasColumnName("ma_datcho");
            entity.Property(e => e.Dichvukhac)
                .HasMaxLength(1000)
                .HasColumnName("dichvukhac");
            entity.Property(e => e.GioDatcho).HasColumnName("gio_datcho");
            entity.Property(e => e.MaBan).HasColumnName("ma_ban");
            entity.Property(e => e.MaNguoidung).HasColumnName("ma_nguoidung");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayDatcho).HasColumnName("ngay_datcho");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SoNguoi).HasColumnName("so_nguoi");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("pending")
                .HasColumnName("trangthai");

            entity.HasOne(d => d.MaBanNavigation).WithMany(p => p.DatChos)
                .HasForeignKey(d => d.MaBan)
                .HasConstraintName("FK__DatCho__ma_ban__4AB81AF0");

            entity.HasOne(d => d.MaNguoidungNavigation).WithMany(p => p.DatChos)
                .HasForeignKey(d => d.MaNguoidung)
                .HasConstraintName("FK__DatCho__ma_nguoi__48CFD27E");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany(p => p.DatChos)
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__DatCho__ma_nhaha__49C3F6B7");
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.MaKhuyenmai).HasName("PK__khuyenma__4EBED2E09A68499F");

            entity.ToTable("khuyenmai");

            entity.Property(e => e.MaKhuyenmai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ma_khuyenmai");
            entity.Property(e => e.Giatri).HasColumnName("giatri");
            entity.Property(e => e.Loaikhuyenmai)
                .HasColumnType("text")
                .HasColumnName("loaikhuyenmai");
            entity.Property(e => e.MaDatcho).HasColumnName("ma_datcho");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.Ngbatdau)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngbatdau");
            entity.Property(e => e.Ngkettuc)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngkettuc");
            entity.Property(e => e.TenKhuyenmai)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_khuyenmai");
            entity.Property(e => e.Trangthai)
                .HasMaxLength(100)
                .HasColumnName("trangthai");

            entity.HasOne(d => d.MaDatchoNavigation).WithMany(p => p.Khuyenmais)
                .HasForeignKey(d => d.MaDatcho)
                .HasConstraintName("FK__khuyenmai__ma_da__4F7CD00D");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.MaNguoidung).HasName("PK__NguoiDun__48823C2E6E48AD64");

            entity.ToTable("NguoiDung");

            entity.Property(e => e.MaNguoidung).HasColumnName("ma_nguoidung");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Matkhau)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("matkhau");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TenDangnhap)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ten_dangnhap");
        });

        modelBuilder.Entity<NhaHang>(entity =>
        {
            entity.HasKey(e => e.MaNhahang).HasName("PK__NhaHang__83FC1422B4140DEA");

            entity.ToTable("NhaHang");

            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.Diachi)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("diachi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanvien).HasName("PK__NhanVien__E5F11965433235AC");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanvien).HasColumnName("ma_nhanvien");
            entity.Property(e => e.ChucVu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("chuc_vu");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.Sdt)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("sdt");
            entity.Property(e => e.TenNhanvien)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_nhanvien");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__NhanVien__ma_nha__693CA210");
        });

        modelBuilder.Entity<ThanhToan>(entity =>
        {
            entity.HasKey(e => e.MaThanhtoan).HasName("PK__ThanhToa__503D905BFE9E1D10");

            entity.ToTable("ThanhToan");

            entity.Property(e => e.MaThanhtoan).HasColumnName("ma_thanhtoan");
            entity.Property(e => e.MaDatcho).HasColumnName("ma_datcho");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.PhuongthucThanhtoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phuongthuc_thanhtoan");
            entity.Property(e => e.Sotien)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("sotien");
            entity.Property(e => e.TrangthaiThanhtoan)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("unpaid")
                .HasColumnName("trangthai_thanhtoan");

            entity.HasOne(d => d.MaDatchoNavigation).WithMany(p => p.ThanhToans)
                .HasForeignKey(d => d.MaDatcho)
                .HasConstraintName("FK__ThanhToan__ma_da__60A75C0F");
        });

        modelBuilder.Entity<ThucDon>(entity =>
        {
            entity.HasKey(e => e.MaThucdon).HasName("PK__ThucDon__8760434ADE6C528D");

            entity.ToTable("ThucDon");

            entity.Property(e => e.MaThucdon).HasColumnName("ma_thucdon");
            entity.Property(e => e.Gia)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("gia");
            entity.Property(e => e.MaNhahang).HasColumnName("ma_nhahang");
            entity.Property(e => e.Mota)
                .HasColumnType("text")
                .HasColumnName("mota");
            entity.Property(e => e.NgayCapnhat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_capnhat");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.TenMon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ten_mon");

            entity.HasOne(d => d.MaNhahangNavigation).WithMany(p => p.ThucDons)
                .HasForeignKey(d => d.MaNhahang)
                .HasConstraintName("FK__ThucDon__ma_nhah__5441852A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
