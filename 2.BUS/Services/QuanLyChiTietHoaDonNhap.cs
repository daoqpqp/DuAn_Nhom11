using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;
using _2.BUS.ViewModels;

namespace _2.BUS.Services
{
    public class QuanLyChiTietHoaDonNhap : IQuanLyChiTietHoaDonNhap
    {
        private IChiTietHoaDonNhapServices _QLCThoadonNhap;
        private List<ChiTietHoaDonNhap> _lisChiTietHoaDonNhap;
        private IQuanLyhoaDonNhap _quanLyHoaDonNhap;
        private IQuanLySanPham _quanLySanPham;
        private IQuanLyNhanVien _quanLyNhanVien;
        private List<ViewHienThi> _lstview;
        public QuanLyChiTietHoaDonNhap()
        {
            _QLCThoadonNhap = new ChiTietHoaDonNhapServices();
            _lisChiTietHoaDonNhap = new List<ChiTietHoaDonNhap>();
            _quanLyHoaDonNhap = new QuanLyhoaDonNhap();
            _quanLySanPham = new QuanLySanPham();
            _quanLyNhanVien = new QuanLyNhanVien();
            _lstview = new List<ViewHienThi>();
            getlChiTietHoaDonNhapfromDB();

        }

        public List<ChiTietHoaDonNhap> getlChiTietHoaDonNhapfromDB()
        {
            return _lisChiTietHoaDonNhap = _QLCThoadonNhap.getlChiTietHoaDonNhapfromDB();
        }

        public bool addChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _QLCThoadonNhap.addChiTietHoaDonNhap(chiTietHoaDonNhap);
            return true;
        }

        public bool deleteChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _QLCThoadonNhap.deleteChiTietHoaDonNhap(chiTietHoaDonNhap);
            return true;
        }

        public bool updateChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _QLCThoadonNhap.updateChiTietHoaDonNhap(chiTietHoaDonNhap);
            return true;
        }

        public List<ViewHienThi> getViewCTHDNhap()
        {
            _lstview = (from a in getlChiTietHoaDonNhapfromDB()
                        join b in _quanLyHoaDonNhap.getlhoaDonNhapfromDB() on a.maHoaDonNhap equals b.maHoaDonNhap
                        join c in _quanLyNhanVien.getlNhanVienfromDB() on b.maNV equals c.maNV
                        join d in _quanLySanPham.getlSanPhamfromDB() on a.maSanPham equals d.maSanPham
                        select new ViewHienThi { ChiTietHoaDonNhaps = a, hoaDonNhaps = b, NhanViens = c, sanPhams = d }).ToList();
            return _lstview;
        }
    }
}
