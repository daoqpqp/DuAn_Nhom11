using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyKhachHang
    {
        List<KhachHang> getlKhachHangfromDB();
        List<ViewHienThi> getViewKhachHang();
        bool addKhachHang(KhachHang khachhang);
        bool deleteKhachHang(KhachHang khachhang);
        bool updateKhachHang(KhachHang khachhang);
    }
}
