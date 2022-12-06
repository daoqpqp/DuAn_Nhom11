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
    public class ChiTietHoaDonBanServices : IChiTietHoaDonBanServices
    {
        private DatabaseContext _DBcontext;
        private List<ChiTietHoaDonBan> _lstChiTietHoaDonBans;
        public ChiTietHoaDonBanServices()
        {
            _DBcontext = new DatabaseContext();
            _lstChiTietHoaDonBans = new List<ChiTietHoaDonBan>();
            getlChiTietHoaDonBanfromDB();
        }

        public List<ChiTietHoaDonBan> getlChiTietHoaDonBanfromDB()
        {
            _lstChiTietHoaDonBans = _DBcontext.ChiTietHoaDonBans.ToList();
            return _lstChiTietHoaDonBans;
        }
        public bool addChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _DBcontext.ChiTietHoaDonBans.Add(chiTietHoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _DBcontext.ChiTietHoaDonBans.Remove(chiTietHoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan)
        {
            _DBcontext.ChiTietHoaDonBans.Update(chiTietHoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }

    }
}
