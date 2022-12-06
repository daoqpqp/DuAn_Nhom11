using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLySoLuongTon
    {
        List<SoLuongTon> getlSoLuongTonfromDB();
        bool addSoLuongTon(SoLuongTon soLuongTon);
        bool deleteSoLuongTon(SoLuongTon soLuongTon);
        bool updateSoLuongTon(SoLuongTon soLuongTon);
        List<ViewHienThi> getViewSLton();
    }
}
