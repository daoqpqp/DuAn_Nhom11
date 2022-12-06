using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyhoaDonNhap
    {
        List<hoaDonNhap> getlhoaDonNhapfromDB();
        bool addhoaDonNhap(hoaDonNhap hoadonnhap);
        bool deletehoaDonNhap(hoaDonNhap hoadonnhap);
        bool updatehoaDonNhap(hoaDonNhap hoadonnhap);
    }
}
