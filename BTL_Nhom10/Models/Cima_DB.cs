namespace BTL_Nhom10.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cima_DB : DbContext
    {
        public Cima_DB()
            : base("name=Cima_DB")
        {
        }

        public virtual DbSet<ChiTietDH> ChiTietDHs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDH>()
                .Property(e => e.MaDH)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietDH>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<DanhMuc>()
                .Property(e => e.MaDM)
                .IsFixedLength();

            modelBuilder.Entity<DonHang>()
                .Property(e => e.MaDH)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.AnhSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.ThongSo)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaDM)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TaiKhoan1)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.Email)
                .IsFixedLength();
        }
    }
}
