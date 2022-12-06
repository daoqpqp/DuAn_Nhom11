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
    public class QuanLySanPham: IQuanLySanPham
    {
        private ISanPhamServices _IQLSanPham;
        private IChiTietHoaDonBanServices _ChiTietHoaDonBanServices;
        private List<SanPham> _LstSanPham;
        private List<ViewHienThi> _lstview;
        public QuanLySanPham()
        {
            _ChiTietHoaDonBanServices = new ChiTietHoaDonBanServices();
            _LstSanPham = new List<SanPham>();
            _IQLSanPham = new SanPhamServices();
            _lstview = new List<ViewHienThi>();
            getlSanPhamfromDB();
        }

        public List<SanPham> getlSanPhamfromDB()
        {
            return _LstSanPham = _IQLSanPham.getlSanPhamfromDB();
        }

        public bool addSanPham(SanPham sanpham)
        {
            _IQLSanPham.addSanPham(sanpham);
            return true;
        }

        public bool deleteSanPham(SanPham sanpham)
        {
            _IQLSanPham.deleteSanPham(sanpham);
            return true;
        }

        public bool updateSanPham(SanPham sanpham)
        {
            _IQLSanPham.updateSanPham(sanpham);
            return true;
        }

        public List<ViewHienThi> getViewSanPham()
        {
            _lstview = (from a in getlSanPhamfromDB()
                        join b in _ChiTietHoaDonBanServices.getlChiTietHoaDonBanfromDB() on a.maSanPham equals b.maSanPham
                        select new ViewHienThi { sanPhams = a, ChiTietHoaDonBans = b }).ToList();
            return _lstview;
        }
    }
}
