namespace WindowsFormsApplication1.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLBHEntities : DbContext
    {
        public QLBHEntities()
            : base("name=QLBHEntities")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BOPHAN> BOPHANs { get; set; }
        public virtual DbSet<CHITIET_HOADON> CHITIET_HOADON { get; set; }
        public virtual DbSet<CHITIET_TONKHO> CHITIET_TONKHO { get; set; }
        public virtual DbSet<DONVITINH> DONVITINHs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<KHUVUC> KHUVUCs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHOMSANPHAM> NHOMSANPHAMs { get; set; }
        public virtual DbSet<ROLE> ROLEs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BOPHAN>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.BOPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CHITIET_HOADON>()
                .Property(e => e.THANHTIEN)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DONVITINH>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.DONVITINH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIET_HOADON)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUVUC>()
                .HasMany(e => e.KHACHHANGs)
                .WithRequired(e => e.KHUVUC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TONKHOes)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHOMSANPHAM>()
                .HasMany(e => e.SANPHAMs)
                .WithRequired(e => e.NHOMSANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.ACCOUNTs)
                .WithRequired(e => e.ROLE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIABANSI)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.GIABANLE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIET_HOADON)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIET_TONKHO)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.KHOHANG)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<TONKHO>()
                .HasMany(e => e.CHITIET_TONKHO)
                .WithRequired(e => e.TONKHO)
                .WillCascadeOnDelete(false);
        }
    }
}
