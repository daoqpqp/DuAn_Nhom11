using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;

namespace _2.BUS.Services
{
    public class QuanLynhaCungCap: IQuanLynhaCungCap
    {
        private InhaCungCapServices _IQLnhaCungCap;
        private List<nhaCungCap> _LstnhaCungCap;
        public QuanLynhaCungCap()
        {
            _LstnhaCungCap = new List<nhaCungCap>();
            _IQLnhaCungCap = new nhaCungCapServices();
            getlnhaCungCapfromDB();
        }

        public List<nhaCungCap> getlnhaCungCapfromDB()
        {
            return _LstnhaCungCap = _IQLnhaCungCap.getlnhaCungCapfromDB();
        }

        public bool addnhaCungCap(nhaCungCap nhacungcap)
        {
            _IQLnhaCungCap.addnhaCungCap(nhacungcap);
            return true;
        }

        public bool deletenhaCungCap(nhaCungCap nhacungcap)
        {
            _IQLnhaCungCap.deletenhaCungCap(nhacungcap);
            return true;
        }

        public bool updatenhaCungCap(nhaCungCap nhacungcap)
        {
            _IQLnhaCungCap.updatenhaCungCap(nhacungcap);
            return true;
        }
    }
}
