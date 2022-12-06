using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLynhaCungCap
    {
        List<nhaCungCap> getlnhaCungCapfromDB();
        bool addnhaCungCap(nhaCungCap nhacungcap);
        bool deletenhaCungCap(nhaCungCap nhacungcap);
        bool updatenhaCungCap(nhaCungCap nhacungcap);
    }
}
