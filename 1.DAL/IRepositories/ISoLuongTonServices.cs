using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface ISoLuongTonServices
    {
        List<SoLuongTon> getlSoLuongTonfromDB();
        bool addSoLuongTon(SoLuongTon soLuongTon);
        bool deleteSoLuongTon(SoLuongTon soLuongTon);
        bool updateSoLuongTon(SoLuongTon soLuongTon);
    }
}
