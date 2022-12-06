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
    public class QuanLySoLuongTon : IQuanLySoLuongTon
    {
        private ISoLuongTonServices _IQLSoLuongTon;
        private ISanPhamServices _PhamServices;
        private List<SoLuongTon> _LstSoLuongTon;
        private List<ViewHienThi> _lstview;
        public QuanLySoLuongTon()
        {
            _LstSoLuongTon = new List<SoLuongTon>();
            _IQLSoLuongTon = new SoLuongTonServices();
            _PhamServices = new SanPhamServices();
            getlSoLuongTonfromDB();
            _lstview = new List<ViewHienThi>();
        }

        public List<SoLuongTon> getlSoLuongTonfromDB()
        {
            return _LstSoLuongTon = _IQLSoLuongTon.getlSoLuongTonfromDB();
        }

        public bool addSoLuongTon(SoLuongTon soLuongTon)
        {
            _IQLSoLuongTon.addSoLuongTon(soLuongTon);
            return true;
        }

        public bool deleteSoLuongTon(SoLuongTon soLuongTon)
        {
            _IQLSoLuongTon.deleteSoLuongTon(soLuongTon);
            return true;
        }

        public bool updateSoLuongTon(SoLuongTon soLuongTon)
        {
            _IQLSoLuongTon.updateSoLuongTon(soLuongTon);
            return true;
        }

        public List<ViewHienThi> getViewSLton()
        {
            _lstview = (from a in getlSoLuongTonfromDB()
                        join b in _PhamServices.getlSanPhamfromDB() on a.maSanPham equals b.maSanPham
                        select new ViewHienThi { SoLuongTons = a, sanPhams = b }).ToList();
            return _lstview;
        }
    }
}
