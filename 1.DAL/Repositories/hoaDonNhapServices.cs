using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class hoaDonNhapServices : IhoaDonNhapServices
    {
        private DatabaseContext _DBcontext;
        private List<hoaDonNhap> _lsthoaDonNhaps;
        public hoaDonNhapServices()
        {
            _lsthoaDonNhaps = new List<hoaDonNhap>();
            _DBcontext = new DatabaseContext();
            getlhoaDonNhapfromDB();
        }

        public List<hoaDonNhap> getlhoaDonNhapfromDB()
        {
            _lsthoaDonNhaps = _DBcontext.HoaDonnhaps.ToList();
            return _lsthoaDonNhaps;
        }
        public bool addhoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _DBcontext.HoaDonnhaps.Add(hoadonnhap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deletehoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _DBcontext.HoaDonnhaps.Remove(hoadonnhap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updatehoaDonNhap(hoaDonNhap hoadonnhap)
        {
            _DBcontext.HoaDonnhaps.Update(hoadonnhap);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
