using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyHoaDonBan
    {
        List<HoaDonBan> getlHoaDonBanfromDB();
        bool addHoaDonBan(HoaDonBan hoaDonBan);
        bool deleteHoaDonBan(HoaDonBan hoaDonBan);
        bool updateHoaDonBan(HoaDonBan hoaDonBan);
    }
}
