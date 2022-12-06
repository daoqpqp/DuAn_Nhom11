using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.FmKhachHang;

namespace _3.GUI.ChucNang
{
    public partial class FromHoaDonBan : Form
    {
        public string msp;
        public int gt;
        public static string maHD;
        public static string tongTien;
        public static DateTime ngayLap;
        //public static string nguoiLap;
        List<ChiTietHoaDonBan> _lstChiTietHD;
        IQuanLySanPham _IQLSanPham;
        IQuanLyNhanVien _IQLNhanVien;
        IQuanLyChiTietHoaDonBan _IQLChiTietHoaDonBan;
        IQuanLyHoaDonBan _QLHDBan;
        IQuanLyKhachHang _IQLKH;
        IQuanLySoLuongTon _QLSLton;
        int tongtien = 0;
        public FromHoaDonBan()
        {
            InitializeComponent();
            _QLSLton = new QuanLySoLuongTon();
            tbt_mahd.Text = FmDanhSachKH.MaHD1;
            _QLHDBan = new QuanLyHoaDonBan();
            _IQLNhanVien = new QuanLyNhanVien();
            //foreach (var item in _IQLNhanVien.getlNhanVienfromDB())
            //{
            //    cb_nguoilap.Items.Add(item.maNV);
            //}
            tbt_hoten.Text = FmDanhSachKH.hoTen;
            tbt_dc.Text = FmDanhSachKH.dc;
            tbt_sdt.Text = FmDanhSachKH.SDT;
            _IQLSanPham = new QuanLySanPham();
            _IQLChiTietHoaDonBan = new QuanLyChiTietHoaDonBan();
            _IQLKH = new QuanLyKhachHang();
            _lstChiTietHD = new List<ChiTietHoaDonBan>();
            LoadDuLieu();

            //Hóa Đơn Chờ
            dgv_hdc.Rows.Clear();
            foreach (var item in _QLHDBan.getlHoaDonBanfromDB())
            {
                dgv_hdc.Rows.Add(item.maHD, item.trangThaiBan == true ? "Đã Thanh Toán" : "Chưa Thanh Toán");
            }
            
        }
        public void LoadDuLieu()
        {
            dgv1.Rows.Clear();
            foreach (var item in _QLSLton.getViewSLton())
            {
                dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            tongTien = tongtien.ToString();
            maHD = tbt_mahd.Text;
            ngayLap = dateTimePicker1.Value;
            //nguoiLap = cb_nguoilap.Text;
            FromChiTietHoaDonBan CTHDban = new FromChiTietHoaDonBan();
            CTHDban.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void tbt_tensp_tim_TextChanged_1(object sender, EventArgs e)
        {
            var timkiem = _QLSLton.getViewSLton().Where(p => p.sanPhams.tenSanPham.Contains(tbt_tensp_tim.Text));
            dgv1.Rows.Clear();
            foreach (var item in _QLSLton.getViewSLton())
            {
                dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
            }
        }

        private void cb_dongia_tim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_dongia_tim.Text == "Tất Cả")
            {
                dgv1.Rows.Clear();
                foreach (var item in _QLSLton.getViewSLton())
                {
                    dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                }
            }
            else
            {
                var timkiem1 = _QLSLton.getViewSLton().Where(p => p.sanPhams.giaBan <= 2000000);
                var timkiem2 = _QLSLton.getViewSLton().Where(p => p.sanPhams.giaBan <= 3000000);
                var timkiem3 = _QLSLton.getViewSLton().Where(p => p.sanPhams.giaBan <= 4000000);
                var timkiem4 = _QLSLton.getViewSLton().Where(p => p.sanPhams.giaBan <= 5000000);
                var timkiem5 = _QLSLton.getViewSLton().Where(p => p.sanPhams.giaBan > 5000000);

                if (cb_dongia_tim.Text == "<2tr")
                {
                    dgv1.Rows.Clear();
                    foreach (var item in timkiem1)
                    {
                        dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                    }
                }
                if (cb_dongia_tim.Text == "<3tr")
                {
                    dgv1.Rows.Clear();
                    foreach (var item in timkiem2)
                    {
                        dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                    }
                }
                if (cb_dongia_tim.Text == "<4tr")
                {
                    dgv1.Rows.Clear();
                    foreach (var item in timkiem3)
                    {
                        dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                    }
                }
                if (cb_dongia_tim.Text == "<5tr")
                {
                    dgv1.Rows.Clear();
                    foreach (var item in timkiem4)
                    {
                        dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                    }
                }
                if (cb_dongia_tim.Text == ">5tr")
                {
                    dgv1.Rows.Clear();
                    foreach (var item in timkiem5)
                    {
                        dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                    }
                }
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cb_size_tim_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_size_tim.Text == "Tất Cả")
            {
                dgv1.Rows.Clear();
                foreach (var item in _QLSLton.getViewSLton())
                {
                    dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                }
            }
            else
            {
                var timkiem1 = _QLSLton.getViewSLton().Where(p => p.SoLuongTons.size == cb_size_tim.Text);
                dgv1.Rows.Clear();
                foreach (var item in timkiem1)
                {
                    dgv1.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn, item.sanPhams.giaBan, item.sanPhams.tinhTrang == true ? "Còn Hàng" : "Hết Hàng");
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgv2.Rows.Add(tbt_masp.Text, cb_tensp.Text, cb_size.Text, tbt_slMua.Text, tbt_dongia.Text, tbt_tongtien.Text);
            ChiTietHoaDonBan cthd = new ChiTietHoaDonBan()
            {
                maHD = tbt_mahd.Text,
                giaBan = Convert.ToInt32(tbt_dongia.Text),
                soLuongBan = Convert.ToInt32(tbt_slMua.Text),
                Size = cb_size.Text,
                maSanPham = tbt_masp.Text,
                tongTienBan = Convert.ToInt32(tbt_dongia.Text) * Convert.ToInt32(tbt_slMua.Text)
            };
            _IQLChiTietHoaDonBan.addChiTietHoaDonBan(cthd);
            //TongTien();
            //int tongtien = 0;
            //for (int i = 0; i < dgv2.Rows.Count; i++)
            //{
            //    tongtien = tongtien + Convert.ToInt32(dgv2.Rows[i].Cells[4].Value.ToString());
            //}
            //lblTongTien.Text = "Tổng tiền:" + tongtien + "";

            tongtien = tongtien + Convert.ToInt32(tbt_tongtien.Text);
            lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString();
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult DialogResult = MessageBox.Show("Bạn có muốn thêm vào giỏ? ",
                    "...", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    DataGridViewRow row = dgv1.Rows[e.RowIndex];
                    dgv2.Rows.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[4].Value.ToString());
                }
            }
        }

        private void tbt_slMua_TextChanged(object sender, EventArgs e)
        {
            if (tbt_slMua.Text != "")
            {
                tbt_tongtien.Text = Convert.ToString(Convert.ToInt32(tbt_slMua.Text) * Convert.ToInt32(tbt_dongia.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_IQLChiTietHoaDonBan.getlChiTietHoaDonBanfromDB().Any())
            {
                var item = _IQLChiTietHoaDonBan.getlChiTietHoaDonBanfromDB().FirstOrDefault(p => p.maSanPham == msp);
                _IQLChiTietHoaDonBan.deleteChiTietHoaDonBan(item);
                tongtien = tongtien - gt;
                lblTongTien.Text = "Tổng Tiền: " + tongtien.ToString();
                MessageBox.Show("xóa thành công");

            }
            else
            {
                MessageBox.Show("Chưa có sản phẩm nào trong giỏ hàng");
            }
            foreach (DataGridViewCell oneCell in dgv2.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    dgv2.Rows.RemoveAt(oneCell.RowIndex);
                }

            }
        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv1.Rows[e.RowIndex];
            tbt_masp.Text = row.Cells[0].Value.ToString();
            cb_tensp.Text = row.Cells[1].Value.ToString();
            cb_size.Text = row.Cells[2].Value.ToString();
            tbt_slTon.Text = row.Cells[3].Value.ToString();
            tbt_dongia.Text = row.Cells[4].Value.ToString();
        }

        private void dgv2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv2.Rows[e.RowIndex];
                msp = r.Cells[0].Value.ToString();
                gt = Convert.ToInt32(r.Cells[5].Value.ToString());
                //MessageBox.Show(msp);
            }
        }

        private void dgv_hdc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row1 = dgv_hdc.Rows[e.RowIndex];
            tbt_mahd.Text = row1.Cells[0].Value.ToString();
            var laySDT = _QLHDBan.getlHoaDonBanfromDB().Where(p => p.maHD == tbt_mahd.Text).Select(p => p.SDT_KH).FirstOrDefault();
            tbt_sdt.Text = laySDT;
            var layHoTen = _IQLKH.getlKhachHangfromDB().Where(p => p.SDT_KH == laySDT).Select(p => p.tenKH).FirstOrDefault();
            var layDC = _IQLKH.getlKhachHangfromDB().Where(p => p.SDT_KH == laySDT).Select(p => p.diaChi_KH).FirstOrDefault();
            tbt_hoten.Text = layHoTen;
            tbt_dc.Text = layDC;
            var x = _IQLChiTietHoaDonBan.getViewCTHDban().Where(p => p.hoaDonBans.maHD == tbt_mahd.Text);
            dgv2.Rows.Clear();
            foreach (var item in x)
            {

                dgv2.Rows.Add(item.sanPhams.maSanPham, item.sanPhams.tenSanPham, item.ChiTietHoaDonBans.Size, item.ChiTietHoaDonBans.soLuongBan, item.ChiTietHoaDonBans.giaBan, item.ChiTietHoaDonBans.tongTienBan);
            }
            int d = 0;
            for (int i = 0; i < dgv2.Rows.Count; i++)
            {
                d = d + Convert.ToInt32(dgv2.Rows[i].Cells[5].Value);
            }
            lblTongTien.Text = "Tổng Tiền: " + d;
        }
    }
}
