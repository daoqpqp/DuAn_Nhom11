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
    public class ChiTietHoaDonNhapServices : IChiTietHoaDonNhapServices
    {
        private DatabaseContext _DBcontext;
        private List<ChiTietHoaDonNhap> _lstChiTietHoaDonNhaps;
        public ChiTietHoaDonNhapServices()
        {
            _DBcontext = new DatabaseContext();
            _lstChiTietHoaDonNhaps = new List<ChiTietHoaDonNhap>();
            getlChiTietHoaDonNhapfromDB();
        }

        public List<ChiTietHoaDonNhap> getlChiTietHoaDonNhapfromDB()
        {
            _lstChiTietHoaDonNhaps = _DBcontext.ChiTietHoaDonNhaps.ToList();
            return _lstChiTietHoaDonNhaps;
        }
        public bool addChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _DBcontext.ChiTietHoaDonNhaps.Add(chiTietHoaDonNhap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _DBcontext.ChiTietHoaDonNhaps.Remove(chiTietHoaDonNhap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap)
        {
            _DBcontext.ChiTietHoaDonNhaps.Update(chiTietHoaDonNhap);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
