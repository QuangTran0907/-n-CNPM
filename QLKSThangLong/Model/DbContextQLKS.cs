using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKSThangLong.Model
{
    public partial class DbContextQLKS : DbContext
    {
        public DbContextQLKS()
            : base("name=DbContextQLKS")
        {
        }

        public virtual DbSet<CHITIETPHIEUTHUE> CHITIETPHIEUTHUE { get; set; }
        public virtual DbSet<DICHVU> DICHVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHIEUDANGKIDV> PHIEUDANGKIDV { get; set; }
        public virtual DbSet<PHIEUTHUEPHONG> PHIEUTHUEPHONG { get; set; }
        public virtual DbSet<PHONG> PHONG { get; set; }
        public virtual DbSet<SUDUNGVT> SUDUNGVT { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }
        public virtual DbSet<VATTU> VATTU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETPHIEUTHUE>()
                .Property(e => e.MaPhieuThue)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETPHIEUTHUE>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DICHVU>()
                .Property(e => e.GiaDV)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.DichVuSuDung)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TienPhong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.TongTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.CMND_CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDANGKIDV>()
                .Property(e => e.MaPhieuDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDANGKIDV>()
                .Property(e => e.Tongtien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUDANGKIDV>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUDANGKIDV>()
                .Property(e => e.MaDV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .Property(e => e.MaPhieuThue)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUEPHONG>()
                .HasMany(e => e.CHITIETPHIEUTHUE)
                .WithRequired(e => e.PHIEUTHUEPHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.GiaPhong)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.TienDV)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.CHITIETPHIEUTHUE)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.HOADON)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.SUDUNGVT)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SUDUNGVT>()
                .Property(e => e.SoPhong)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUDUNGVT>()
                .Property(e => e.MaVT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MaTK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TenTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<VATTU>()
                .Property(e => e.MaVT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VATTU>()
                .HasMany(e => e.SUDUNGVT)
                .WithRequired(e => e.VATTU)
                .WillCascadeOnDelete(false);
        }
    }
}
