using _1.DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewHienThi
    {
        public SanPham sanPhams { get; set; } = default!;
        public ChiTietHoaDonBan ChiTietHoaDonBans { get; set; } = default!;
        public ChiTietHoaDonNhap ChiTietHoaDonNhaps { get; set; } = default!;
        public hoaDonNhap hoaDonNhaps { get; set; } = default!;
        public HoaDonBan hoaDonBans { get; set; } = default!;
        public KhachHang KhachHangs { get; set; } = default!;
        public nhaCungCap nhaCungCaps { get; set; } = default!;
        public NhanVien NhanViens { get; set; } = default!;
        public SoLuongTon SoLuongTons { get; set; } = default!;
    }
}
