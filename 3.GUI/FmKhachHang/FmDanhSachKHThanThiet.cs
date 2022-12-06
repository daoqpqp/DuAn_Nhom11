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

namespace _3.GUI.FmKhachHang
{
    public partial class FmDanhSachKHThanThiet : Form
    {
        IQuanLyKhachHang _QLKhachHang;

        public FmDanhSachKHThanThiet()
        {
            InitializeComponent();
            _QLKhachHang = new QuanLyKhachHang();
             var hangHoa = _QLKhachHang.getViewKhachHang().GroupBy(p => p.hoaDonBans.SDT_KH)
                .Select(g => new
                {
                    ma = g.Key,
                    ten = g.First().KhachHangs.tenKH,
                    diaChi = g.First().KhachHangs.diaChi_KH,
                    value = g.Sum(s => s.ChiTietHoaDonBans.tongTienBan)
                });
            foreach (var item in hangHoa)
            {
                dataGridView1.Rows.Add(item.ma, item.ten, item.diaChi, item.value);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }
    }
}
