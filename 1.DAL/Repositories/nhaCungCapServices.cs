using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.Context;
using _1.DAL.DomainModels;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class nhaCungCapServices : InhaCungCapServices
    {
        private DatabaseContext _DBcontext;
        private List<nhaCungCap> _lstnhaCungCaps;
        public nhaCungCapServices()
        {
            _lstnhaCungCaps = new List<nhaCungCap>();
            _DBcontext = new DatabaseContext();
            getlnhaCungCapfromDB();
        }

        public List<nhaCungCap> getlnhaCungCapfromDB()
        {
            _lstnhaCungCaps = _DBcontext.NhaCungCaps.ToList();
            return _lstnhaCungCaps;
        }
        public bool addnhaCungCap(nhaCungCap nhacungcap)
        {
            _DBcontext.NhaCungCaps.Add(nhacungcap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deletenhaCungCap(nhaCungCap nhacungcap)
        {
            _DBcontext.NhaCungCaps.Remove(nhacungcap);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updatenhaCungCap(nhaCungCap nhacungcap)
        {
            _DBcontext.NhaCungCaps.Update(nhacungcap);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
