﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;

namespace _1.DAL.IRepositories
{
    public interface INhanVienServices
    {
        List<NhanVien> getlNhanVienfromDB();
        bool addNhanVien(NhanVien nhanvien);
        bool deleteNhanVien(NhanVien nhanvien);
        bool updateNhanVien(NhanVien nhanvien);
    }
}
