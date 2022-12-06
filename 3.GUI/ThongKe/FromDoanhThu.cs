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

namespace _3.GUI.ThongKe
{
    public partial class FromDoanhThu : Form
    {
        IQuanLyChiTietHoaDonBan _QLCThoadonBan;
        IQuanLyChiTietHoaDonNhap _QLCThoadonNhap;
        public FromDoanhThu()
        {
            InitializeComponent();
            _QLCThoadonBan = new QuanLyChiTietHoaDonBan();
            _QLCThoadonNhap = new QuanLyChiTietHoaDonNhap();
           

        }

        private void getheaderBan() // THAY ĐỔI TÊN CỘT
        {
            dataGridView2.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView2.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView2.Columns[2].HeaderText = "Giá bán";
            dataGridView2.Columns[3].HeaderText = "Size";
            dataGridView2.Columns[4].HeaderText = "Số lượng bán";
            dataGridView2.Columns[5].HeaderText = "Ngày bán";
            dataGridView2.Columns[6].HeaderText = "Người bán";
            dataGridView2.Columns[7].HeaderText = "Tổng tiền bán";
        }
        private void getheaderNhap() // THAY ĐỔI TÊN CỘT
        {
            dataGridView2.Columns[0].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns[2].HeaderText = "Giá nhập";
            dataGridView1.Columns[3].HeaderText = "Ngày nhập";
            dataGridView1.Columns[4].HeaderText = "Số lượng bán";
            dataGridView1.Columns[5].HeaderText = "Ngày bán";
            dataGridView1.Columns[6].HeaderText = "Người nhập";
            dataGridView1.Columns[7].HeaderText = "Tổng tiền nhập";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Convert.ToString(dateTimePicker2.Value);
            string b = Convert.ToString(dateTimePicker1.Value);
            if (a == b)
            {
                MessageBox.Show("Không được trùng ngày, ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else if (dateTimePicker2.Value >= dateTimePicker1.Value)
            {
                MessageBox.Show("Ngày sau phải lớn hơn ngày trước ít nhất một ngày!!!");
            }
            else
            {
                var SPban = _QLCThoadonBan.getViewCTHDban().GroupBy(p => p.hoaDonBans.maHD)
               .Select(g => new
               {
                   ma = g.Key,
                   ten = g.First().sanPhams.tenSanPham,
                   gia = g.First().ChiTietHoaDonBans.giaBan,
                   Size = g.First().ChiTietHoaDonBans.Size,
                   sl = g.First().ChiTietHoaDonBans.soLuongBan,
                   date = g.First().hoaDonBans.ngayban,
                   tenNV = g.First().NhanViens.TenNV,
                   value = g.Sum(s => s.ChiTietHoaDonBans.tongTienBan)
               });
                foreach (var item in SPban)
                {
                    dataGridView2.Rows.Add(item.ma, item.ten, item.gia, item.Size, item.sl, item.date, item.tenNV, item.value);
                }

                //TÍNH TỔNG TIỀN BÁN
                int d = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    d = d + Convert.ToInt32(dataGridView2.Rows[i].Cells[7].Value);
                }
                textBox2.Text = d + "";

                var SPNhap = _QLCThoadonNhap.getViewCTHDNhap().GroupBy(p => p.hoaDonNhaps.maHoaDonNhap)
                    .Select(g => new
                    {
                        ma = g.Key,
                        ten = g.First().sanPhams.tenSanPham,
                        sl = g.First().ChiTietHoaDonNhaps.SoLuongNhap,
                        gia = g.First().ChiTietHoaDonNhaps.donGiaNhap,
                        date = g.First().hoaDonNhaps.ngayNhap,
                        tenNV = g.First().NhanViens.TenNV,
                        value = g.Sum(s => s.ChiTietHoaDonNhaps.tongTienNhap)
                    });
                foreach (var item in SPNhap)
                {
                    dataGridView2.Rows.Add(item.ma, item.ten, item.gia, item.date, item.tenNV, item.value);
                }
                int k = 0;

                //TÍNH TỔNG TIỀN NHẬP
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    k = k + Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                }
                textBox1.Text = k + "";
                textBox3.Text = d - k + "";
            }

        }
    }
}
