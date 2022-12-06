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
    public class QuanLyChiTietHoaDonBan : IQuanLyChiTietHoaDonBan
    {
        private IChiTietHoaDonBanServices _QLCThoadonban;
        private List<ChiTietHoaDonBan> _lisChiTietHoaDonBan;
        private IQuanLyHoaDonBan _quanLyHoaDonBan;
        private IQuanLySanPham _quanLySanPham;
        private IQuanLyNhanVien _quanLyNhanVien;
        private List<ViewHienThi> _lstview;
        public QuanLyChiTietHoaDonBan()
        {
            _QLCThoadonban = new ChiTietHoaDonBanServices();
            _lisChiTietHoaDonBan = new List<ChiTietHoaDonBan>();
            _quanLyHoaDonBan = new QuanLyHoaDonBan();
            _quanLySanPham = new QuanLySanPham();
            _quanLyNhanVien = new QuanLyNhanVien();
            _lstview = new List<ViewHienThi>();
            getlChiTietHoaDonBanfromDB();
        }

        public List<ChiTietHoaDonBan> getlChiTietHoaDonBanfromDB()
        {
            return _lisChiTietHoaDonBan = _QLCThoadonban.getlChiTietHoaDonBanfromDB();
        }

        public bool addChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _QLCThoadonban.addChiTietHoaDonBan(chiTietHoaDonBan);
            return true;
        }

        public bool deleteChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _QLCThoadonban.deleteChiTietHoaDonBan(chiTietHoaDonBan);
            return true;
        }

        public bool updateChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _QLCThoadonban.updateChiTietHoaDonBan(chiTietHoaDonBan);
            return true;
        }

        public List<ViewHienThi> getViewCTHDban()
        {
            _lstview = (from a in getlChiTietHoaDonBanfromDB()
                        join b in _quanLyHoaDonBan.getlHoaDonBanfromDB() on a.maHD equals b.maHD
                        join c in _quanLyNhanVien.getlNhanVienfromDB() on b.maNV equals c.maNV
                        join d in _quanLySanPham.getlSanPhamfromDB() on a.maSanPham equals d.maSanPham
                        select new ViewHienThi { ChiTietHoaDonBans = a, hoaDonBans = b, NhanViens = c, sanPhams = d }).ToList();
            return _lstview;
        }
    }
}
