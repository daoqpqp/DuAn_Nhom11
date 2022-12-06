using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.GUI.ThongKe
{
    public partial class FromSanPhamBanChayNhat : Form
    {
        IQuanLySanPham _QLSP;
        public FromSanPhamBanChayNhat()
        {
            InitializeComponent();
            _QLSP = new QuanLySanPham();
            var sp = _QLSP.getViewSanPham().GroupBy(p => p.sanPhams.maSanPham)
                .Select(g => new
                {
                    ma = g.Key,
                    ten = g.First().sanPhams.tenSanPham,
                    value = g.Sum(s => s.ChiTietHoaDonBans.soLuongBan)
                });
            foreach (var item in sp)
            {
                dataGridView1.Rows.Add(item.ma, item.ten, item.value);
            }
        }
    }
}
