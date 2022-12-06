using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IChiTietHoaDonNhapServices
    {
        List<ChiTietHoaDonNhap> getlChiTietHoaDonNhapfromDB();
        bool addChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
        bool deleteChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
        bool updateChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
    }
}
