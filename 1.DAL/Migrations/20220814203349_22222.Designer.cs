// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220814203349_22222")]
    partial class _22222
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietHoaDonBan", b =>
                {
                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("giaBan")
                        .HasColumnType("int");

                    b.Property<int>("soLuongBan")
                        .HasColumnType("int");

                    b.Property<int>("tongTienBan")
                        .HasColumnType("int");

                    b.HasKey("maSanPham", "maHD");

                    b.HasIndex("maHD");

                    b.ToTable("ChiTietHoaDonBan");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietHoaDonNhap", b =>
                {
                    b.Property<string>("maHoaDonNhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.Property<float>("donGiaNhap")
                        .HasColumnType("real");

                    b.Property<float>("tongTienNhap")
                        .HasColumnType("real");

                    b.HasKey("maHoaDonNhap", "maSanPham");

                    b.HasIndex("maSanPham");

                    b.ToTable("ChiTietHoaDonNhap");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonBan", b =>
                {
                    b.Property<string>("maHD")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SDT_KH")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayban")
                        .HasColumnType("datetime2");

                    b.HasKey("maHD");

                    b.HasIndex("SDT_KH");

                    b.HasIndex("maNV");

                    b.ToTable("HoaDonBan");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Property<string>("SDT_KH")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("diaChi_KH")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("tenKH")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SDT_KH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Property<string>("maNV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("chucVu")
                        .HasColumnType("bit");

                    b.Property<string>("diaChi")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("gioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("matKhau")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("maNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maSanPham");

                    b.Property<float>("giaBan")
                        .HasColumnType("real");

                    b.Property<string>("hinhAnh")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<float>("size")
                        .HasColumnType("real");

                    b.Property<int>("soLuong")
                        .HasColumnType("int");

                    b.Property<string>("tenSanPham")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("tinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("maSanPham");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SoLuongTon", b =>
                {
                    b.Property<string>("maSanPham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("size")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("soluongton")
                        .HasColumnType("int");

                    b.HasKey("maSanPham", "size");

                    b.ToTable("SoLuongTon");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.hoaDonNhap", b =>
                {
                    b.Property<string>("maHoaDonNhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("maNhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ngayNhap")
                        .HasColumnType("datetime2");

                    b.HasKey("maHoaDonNhap");

                    b.HasIndex("maNV");

                    b.HasIndex("maNhaCungCap");

                    b.ToTable("hoaDonNhap");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.nhaCungCap", b =>
                {
                    b.Property<string>("maNhaCungCap")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("maNhaCungCap");

                    b.Property<string>("SDT_NCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiNCC")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("tenNhaCungCap")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("tinhTrang")
                        .HasColumnType("bit");

                    b.HasKey("maNhaCungCap");

                    b.ToTable("nhaCungCap");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietHoaDonBan", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.HoaDonBan", "HoaDonBan")
                        .WithMany("ChiTietHoaDonBans")
                        .HasForeignKey("maHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.SanPham", "SanPham")
                        .WithMany("ChiTietHoaDonBans")
                        .HasForeignKey("maSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonBan");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.ChiTietHoaDonNhap", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.hoaDonNhap", "hoaDonNhap")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("maHoaDonNhap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.SanPham", "SanPham")
                        .WithMany("ChiTietHoaDonNhaps")
                        .HasForeignKey("maSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoaDonNhap");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonBan", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.KhachHang", "IDkhachHang")
                        .WithMany("HoaDonBans")
                        .HasForeignKey("SDT_KH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.NhanVien", "IDnhanVien")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("maNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDkhachHang");

                    b.Navigation("IDnhanVien");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SoLuongTon", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.SanPham", "SanPham")
                        .WithMany("soLuongTons")
                        .HasForeignKey("maSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.hoaDonNhap", b =>
                {
                    b.HasOne("_1.DAL.DomainModels.NhanVien", "nhanViens")
                        .WithMany("HoaDonBans")
                        .HasForeignKey("maNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.DomainModels.nhaCungCap", "NhaCungCaps")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("maNhaCungCap")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaCungCaps");

                    b.Navigation("nhanViens");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.HoaDonBan", b =>
                {
                    b.Navigation("ChiTietHoaDonBans");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.KhachHang", b =>
                {
                    b.Navigation("HoaDonBans");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.NhanVien", b =>
                {
                    b.Navigation("HoaDonBans");

                    b.Navigation("HoaDonNhaps");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.SanPham", b =>
                {
                    b.Navigation("ChiTietHoaDonBans");

                    b.Navigation("ChiTietHoaDonNhaps");

                    b.Navigation("soLuongTons");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.hoaDonNhap", b =>
                {
                    b.Navigation("ChiTietHoaDonNhaps");
                });

            modelBuilder.Entity("_1.DAL.DomainModels.nhaCungCap", b =>
                {
                    b.Navigation("HoaDonNhaps");
                });
#pragma warning restore 612, 618
        }
    }
}
