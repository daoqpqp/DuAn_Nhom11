using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonBanServices
    {
        List<HoaDonBan> getlHoaDonBanfromDB();
        bool addHoaDonBan(HoaDonBan hoaDonBan);
        bool deleteHoaDonBan(HoaDonBan hoaDonBan);
        bool updateHoaDonBan(HoaDonBan hoaDonBan);
    }
}
