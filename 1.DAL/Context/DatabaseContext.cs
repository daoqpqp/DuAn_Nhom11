using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using Microsoft.EntityFrameworkCore;


namespace _1.DAL.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ChiTietHoaDonNhap>().HasKey(table => new {
                table.maHoaDonNhap,
                table.maSanPham
            });

            builder.Entity<ChiTietHoaDonBan>()
                .HasKey(o => new { o.maSanPham, o.maHD });

            builder.Entity<SoLuongTon>()
                .HasKey(o => new { o.maSanPham, o.size });
        }

        public virtual DbSet<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = default!;
        public virtual DbSet<hoaDonNhap> HoaDonnhaps { get; set; } = default!;
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; } = default!;
        public virtual DbSet<nhaCungCap> NhaCungCaps { get; set; } = default!;
        public virtual DbSet<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; } = default!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = default!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = default!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = default!;
        public virtual DbSet<SoLuongTon> SoLuongTons { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-E0CSS95H\\DAONGUYEN;Initial Catalog=DU_AN;Persist Security Info=True;User ID=daonvph18705;Password=123");
            }
        }
    }
}
