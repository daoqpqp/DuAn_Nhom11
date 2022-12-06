using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyChiTietHoaDonBan
    {
        List<ChiTietHoaDonBan> getlChiTietHoaDonBanfromDB();
        bool addChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
        bool deleteChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
        bool updateChiTietHoaDonBan(ChiTietHoaDonBan chiTietHoaDonBan);
        List<ViewHienThi> getViewCTHDban();
    }
}
