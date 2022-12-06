using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.FmSanPham
{
    public partial class FmDanhSachSPton : Form
    {
        IQuanLySoLuongTon _QLSLton;
        public FmDanhSachSPton()
        {
            InitializeComponent();
            _QLSLton = new QuanLySoLuongTon();

            var SPton = _QLSLton.getViewSLton().GroupBy(p => p.sanPhams.maSanPham)
                .Select(g => new
                {
                    ma = g.Key,
                    ten = g.First().sanPhams.tenSanPham,
                    value = g.Sum(s => s.SoLuongTons.soluongtonn)
                });
            foreach (var item in SPton)
            {
                dataGridView1.Rows.Add(item.ma, item.ten, item.value);
            }
        }


    }
}
