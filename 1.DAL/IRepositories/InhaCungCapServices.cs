using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface InhaCungCapServices
    {
        List<nhaCungCap> getlnhaCungCapfromDB();
        bool addnhaCungCap(nhaCungCap nhacungcap);
        bool deletenhaCungCap(nhaCungCap nhacungcap);
        bool updatenhaCungCap(nhaCungCap nhacungcap);
    }
}
