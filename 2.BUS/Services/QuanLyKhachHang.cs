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
    public class QuanLyKhachHang: IQuanLyKhachHang
    {
        private IKhachHangServices _IQLkhachHang;
        private IHoaDonBanServices _HoaDonBan;
        private IChiTietHoaDonBanServices _ChiTietHoaDonBan;
        private List<KhachHang> _LstKhachHang;

        private List<ViewHienThi> _lstview;
        public QuanLyKhachHang()
        {
            _LstKhachHang = new List<KhachHang>();
            _IQLkhachHang = new KhachHangServices();
            _HoaDonBan = new HoaDonBanServices();
            _ChiTietHoaDonBan = new ChiTietHoaDonBanServices();
            getlKhachHangfromDB();
            _lstview = new List<ViewHienThi>();
        }

        public List<KhachHang> getlKhachHangfromDB()
        {
            return _LstKhachHang = _IQLkhachHang.getlKhachHangfromDB();
        }

        public bool addKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.addKhachHang(khachhang);
            return true;
        }

        public bool deleteKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.deleteKhachHang(khachhang);
            return true;
        }

        public bool updateKhachHang(KhachHang khachhang)
        {
            _IQLkhachHang.updateKhachHang(khachhang);
            return true;
        }
        public List<ViewHienThi> getViewKhachHang()
        {
            _lstview = (from a in getlKhachHangfromDB()
                        join b in _HoaDonBan.getlHoaDonBanfromDB() on a.SDT_KH equals b.SDT_KH
                        join c in _ChiTietHoaDonBan.getlChiTietHoaDonBanfromDB() on b.maHD equals c.maHD
                        select new ViewHienThi { KhachHangs = a, hoaDonBans = b, ChiTietHoaDonBans = c }).ToList();
            return _lstview;
        }
    }
}
