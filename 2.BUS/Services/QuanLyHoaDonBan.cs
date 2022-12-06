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
    public class QuanLyHoaDonBan : IQuanLyHoaDonBan
    {
        private IHoaDonBanServices _IQLHoaDonBan;
        private List<HoaDonBan> _LstHoaDonBan;
        public QuanLyHoaDonBan()
        {
            _LstHoaDonBan = new List<HoaDonBan>();
            _IQLHoaDonBan = new HoaDonBanServices();
            getlHoaDonBanfromDB();
        }

        public List<HoaDonBan> getlHoaDonBanfromDB()
        {
            return _LstHoaDonBan = _IQLHoaDonBan.getlHoaDonBanfromDB();
        }

        public bool addHoaDonBan(HoaDonBan hoaDonBan)
        {
            _IQLHoaDonBan.addHoaDonBan(hoaDonBan);
            return true;
        }

        public bool deleteHoaDonBan(HoaDonBan hoaDonBan)
        {
            _IQLHoaDonBan.deleteHoaDonBan(hoaDonBan);
            return true;
        }

        public bool updateHoaDonBan(HoaDonBan hoaDonBan)
        {
            _IQLHoaDonBan.updateHoaDonBan(hoaDonBan);
            return true;
        }
    }
}
