using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface IKhachHangServices
    {
        List<KhachHang> getlKhachHangfromDB();
        bool addKhachHang(KhachHang khachHang);
        bool deleteKhachHang(KhachHang khachHang);
        bool updateKhachHang(KhachHang khachHang);
    }
}
