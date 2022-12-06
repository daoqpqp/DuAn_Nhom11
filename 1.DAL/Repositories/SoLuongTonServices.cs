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
    public class SoLuongTonServices : ISoLuongTonServices
    {
        private DatabaseContext _DBcontext;
        private List<SoLuongTon> _lstSoLuongTons;
        public SoLuongTonServices()
        {
            _lstSoLuongTons = new List<SoLuongTon>();
            _DBcontext = new DatabaseContext();
            getlSoLuongTonfromDB();
        }

        public List<SoLuongTon> getlSoLuongTonfromDB()
        {
            _lstSoLuongTons = _DBcontext.SoLuongTons.ToList();
            return _lstSoLuongTons;
        }
        public bool addSoLuongTon(SoLuongTon soLuongTon)
        {
            _DBcontext.SoLuongTons.Add(soLuongTon);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool deleteSoLuongTon(SoLuongTon soLuongTon)
        {
            _DBcontext.SoLuongTons.Remove(soLuongTon);
            _DBcontext.SaveChanges();
            return true;
        }

        public bool updateSoLuongTon(SoLuongTon soLuongTon)
        {
            _DBcontext.SoLuongTons.Update(soLuongTon);
            _DBcontext.SaveChanges();
            return true;
        }
    }
}
