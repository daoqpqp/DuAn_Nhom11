using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IChiTietHoaDonBanServices
    {
        List<ChiTietHoaDonBan> getlChiTietHoaDonBanfromDB();
        bool addChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
        bool deleteChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
        bool updateChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
    }
}
