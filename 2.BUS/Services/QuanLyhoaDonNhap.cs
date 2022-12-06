using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;

namespace _2.BUS.Services
{
    public class QuanLyhoaDonNhap : IQuanLyhoaDonNhap
    {
        private IhoaDonNhapServices _IQLHoaDonNhap;
        private List<hoaDonNhap> _LstHoaDonNhap;
        public QuanLyhoaDonNhap()
        {
            _LstHoaDonNhap = new List<hoaDonNhap>();
            _IQLHoaDonNhap = new hoaDonNhapServices();
            getlhoaDonNhapfromDB();
        }

        public List<hoaDonNhap> getlhoaDonNhapfromDB()
        {
            return _LstHoaDonNhap = _IQLHoaDonNhap.getlhoaDonNhapfromDB();
        }

        public bool addhoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _IQLHoaDonNhap.addhoaDonNhap(hoadonnhap);
            return true;
        }

        public bool deletehoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _IQLHoaDonNhap.deletehoaDonNhap(hoadonnhap);
            return true;
        }

        public bool updatehoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _IQLHoaDonNhap.updatehoaDonNhap(hoadonnhap);
            return true;
        }
    }
}
