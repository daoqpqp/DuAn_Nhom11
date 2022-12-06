using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLySanPham
    {
        List<SanPham> getlSanPhamfromDB();
        
        bool addSanPham(SanPham sanpham);
        bool deleteSanPham(SanPham sanpham);
        bool updateSanPham(SanPham sanpham);
        List<ViewHienThi> getViewSanPham();
    }
}
