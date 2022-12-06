using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.DAL.Migrations
{
    public partial class _22222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenKH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    diaChi_KH = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.SDT_KH);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCap",
                columns: table => new
                {
                    maNhaCungCap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenNhaCungCap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SDT_NCC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    diaChiNCC = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCap", x => x.maNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    maNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    diaChi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    soDienThoai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    matKhau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    chucVu = table.Column<bool>(type: "bit", nullable: false),
                    gioiTinh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.maNV);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenSanPham = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    giaBan = table.Column<float>(type: "real", nullable: false),
                    tinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    size = table.Column<float>(type: "real", nullable: false),
                    hinhAnh = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    soLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.maSanPham);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBan",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayban = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SDT_KH = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBan", x => x.maHD);
                    table.ForeignKey(
                        name: "FK_HoaDonBan_KhachHang_SDT_KH",
                        column: x => x.SDT_KH,
                        principalTable: "KhachHang",
                        principalColumn: "SDT_KH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonBan_NhanVien_maNV",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonNhap",
                columns: table => new
                {
                    maHoaDonNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ngayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maNhaCungCap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maNV = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonNhap", x => x.maHoaDonNhap);
                    table.ForeignKey(
                        name: "FK_hoaDonNhap_nhaCungCap_maNhaCungCap",
                        column: x => x.maNhaCungCap,
                        principalTable: "nhaCungCap",
                        principalColumn: "maNhaCungCap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hoaDonNhap_NhanVien_maNV",
                        column: x => x.maNV,
                        principalTable: "NhanVien",
                        principalColumn: "maNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoLuongTon",
                columns: table => new
                {
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    size = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soluongton = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoLuongTon", x => new { x.maSanPham, x.size });
                    table.ForeignKey(
                        name: "FK_SoLuongTon_SanPham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "SanPham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonBan",
                columns: table => new
                {
                    maHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    soLuongBan = table.Column<int>(type: "int", nullable: false),
                    giaBan = table.Column<int>(type: "int", nullable: false),
                    tongTienBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonBan", x => new { x.maSanPham, x.maHD });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBan_HoaDonBan_maHD",
                        column: x => x.maHD,
                        principalTable: "HoaDonBan",
                        principalColumn: "maHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBan_SanPham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "SanPham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonNhap",
                columns: table => new
                {
                    maSanPham = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maHoaDonNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuongNhap = table.Column<int>(type: "int", nullable: false),
                    donGiaNhap = table.Column<float>(type: "real", nullable: false),
                    tongTienNhap = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonNhap", x => new { x.maHoaDonNhap, x.maSanPham });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_hoaDonNhap_maHoaDonNhap",
                        column: x => x.maHoaDonNhap,
                        principalTable: "hoaDonNhap",
                        principalColumn: "maHoaDonNhap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_SanPham_maSanPham",
                        column: x => x.maSanPham,
                        principalTable: "SanPham",
                        principalColumn: "maSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBan_maHD",
                table: "ChiTietHoaDonBan",
                column: "maHD");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhap_maSanPham",
                table: "ChiTietHoaDonNhap",
                column: "maSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBan_maNV",
                table: "HoaDonBan",
                column: "maNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBan_SDT_KH",
                table: "HoaDonBan",
                column: "SDT_KH");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonNhap_maNhaCungCap",
                table: "hoaDonNhap",
                column: "maNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonNhap_maNV",
                table: "hoaDonNhap",
                column: "maNV");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDonBan");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhap");

            migrationBuilder.DropTable(
                name: "SoLuongTon");

            migrationBuilder.DropTable(
                name: "HoaDonBan");

            migrationBuilder.DropTable(
                name: "hoaDonNhap");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "nhaCungCap");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
