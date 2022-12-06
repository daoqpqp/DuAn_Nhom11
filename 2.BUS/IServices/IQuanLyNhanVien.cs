﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainModels;
using _2.BUS.ViewModels;

namespace _2.BUS.IServices
{
    public interface IQuanLyNhanVien
    {
        List<NhanVien> getlNhanVienfromDB();
        bool addNhanVien(NhanVien nhanvien);
        bool deleteNhanVien(NhanVien nhanvien);
        bool updateNhanVien(NhanVien nhanvien);
    }
}
