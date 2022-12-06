using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyChiTietHoaDonNhap
    {
        List<ChiTietHoaDonNhap> getlChiTietHoaDonNhapfromDB();
        bool addChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
        bool deleteChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
        bool updateChiTietHoaDonNhap(ChiTietHoaDonNhap chiTietHoaDonNhap);
        List<ViewHienThi> getViewCTHDNhap();
    }
}
