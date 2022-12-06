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
    public class HoaDonBanServices : IHoaDonBanServices
    {
        private DatabaseContext _DBcontext;
        private List<HoaDonBan> _lsthoaDonBans;
        public HoaDonBanServices()
        {
            _lsthoaDonBans = new List<HoaDonBan>();
            _DBcontext = new DatabaseContext();
            getlHoaDonBanfromDB();
        }

        public List<HoaDonBan> getlHoaDonBanfromDB()
        {
            _lsthoaDonBans = _DBcontext.HoaDonBans.ToList();
            return _lsthoaDonBans;
        }
        public bool addHoaDonBan(HoaDonBan hoaDonBan)
        {
            _DBcontext.HoaDonBans.Add(hoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteHoaDonBan(HoaDonBan hoaDonBan)
        {
            _DBcontext.HoaDonBans.Remove(hoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateHoaDonBan(HoaDonBan hoaDonBan)
        {
            _DBcontext.HoaDonBans.Update(hoaDonBan);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
