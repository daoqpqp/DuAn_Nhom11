using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IhoaDonNhapServices
    {
        List<hoaDonNhap> getlhoaDonNhapfromDB();
        bool addhoaDonNhap(hoaDonNhap hoadonnhap);
        bool deletehoaDonNhap(hoaDonNhap hoadonnhap);
        bool updatehoaDonNhap(hoaDonNhap hoadonnhap);
    }
}
