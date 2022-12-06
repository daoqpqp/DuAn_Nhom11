using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.FmSanPham
{
    public partial class Form1 : Form
    {
        IQuanLySanPham _QLSanPham;
        IQuanLySoLuongTon _QLSLton;

        public string linkanh = "";
        public Form1()
        {
            _QLSanPham = new QuanLySanPham();
            _QLSLton = new QuanLySoLuongTon();
            InitializeComponent();
            loadDuLieu();
            rb_ConHang.Checked = true;
        }
        public void loadDuLieu()
        {
            dtgv_SanPham.Rows.Clear();
            foreach (var item in _QLSanPham.getlSanPhamfromDB())
            {
                dtgv_SanPham.Rows.Add(item.maSanPham, item.tenSanPham, item.giaBan, item.tinhTrang == true ? "Còn hàng" : "hết hàng");
            }
            lbl_Tong.Text = "Tổng số sản phẩm: " + (dtgv_SanPham.Rows.Count - 1);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            SanPham accsp = _QLSanPham.getlSanPhamfromDB().FirstOrDefault
             (p => p.maSanPham == tbt_MaSP.Text);
            string number = tbt_GiaBan.Text;
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            Match match = regex.Match(number);
            if (tbt_MaSP.Text == "" || tbt_TenSP.Text == "" ||
                 tbt_GiaBan.Text == "" ||linkanh == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (!match.Success)
            {
                MessageBox.Show("Số lượng, đơn giá hoặc Size không hợp lệ");
            }
            else if (accsp != null)
            {
                MessageBox.Show("Mã hàng đã tồn tại");
                tbt_MaSP.Text = "";
            }
            else
            {
                SanPham sp = new SanPham()
                {
                    maSanPham = tbt_MaSP.Text,
                    tenSanPham = tbt_TenSP.Text,
                    giaBan = Convert.ToInt32(tbt_GiaBan.Text),
                    tinhTrang = rb_ConHang.Checked,
                    hinhAnh = linkanh
                };
                _QLSanPham.addSanPham(sp);
                MessageBox.Show("Thêm sản phẩm thành công");
                loadDuLieu();
            }
        }

        private void getheader()
        {
            dtgv_slton.Rows.Clear();
            foreach (var item in _QLSLton.getViewSLton())
            {
                dtgv_slton.Rows.Add(item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn);
            }

        }
       

        private void ptb_Avatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (ptb_Avatar.Image != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn đổi ảnh ko?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        linkanh = op.FileName;
                        ptb_Avatar.Image = Image.FromFile(op.FileName);
                        ptb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage; // Chọn mode
                        MessageBox.Show(op.FileName);
                    }
                }
            }
            if (ptb_Avatar.Image == null)
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    linkanh = op.FileName;
                    ptb_Avatar.Image = Image.FromFile(op.FileName);
                    ptb_Avatar.SizeMode = PictureBoxSizeMode.CenterImage;
                    MessageBox.Show(op.FileName);
                }
            }
        }

        private void btn_ThemSize_Click(object sender, EventArgs e)
        {
            //SoLuongTon accsp = _QLSLton.getlSoLuongTonfromDB().FirstOrDefault
            //(p => p.size == cb_Size.Text);
            string number = tbt_SoLuongCon.Text;
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            Match match = regex.Match(number);
            if (!match.Success)
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }else if (cb_Size.Text == "" || tbt_SoLuongCon.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            //else if (accsp != null)
            //{
            //    MessageBox.Show("Sản phẩm đã tồn tại");
            //}
            else
            {
                SoLuongTon sp = new SoLuongTon()
                {
                    maSanPham = tbt_MaSP.Text,
                    size = cb_Size.Text,
                    soluongtonn = Convert.ToInt32(tbt_SoLuongCon.Text)
                };
                _QLSLton.addSoLuongTon(sp);
                MessageBox.Show("Thêm size và số lượng thành công");
                var layma = _QLSLton.getViewSLton().Where(p => p.sanPhams.maSanPham == tbt_MaSP.Text);
                dtgv_slton.Rows.Clear();
                foreach (var item in layma)
                {

                    dtgv_slton.Rows.Add(item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn);
                }
                loadDuLieu();
            }
            
        }

        private void btn_SuaSize_Click(object sender, EventArgs e)
        {
            var update = _QLSLton.getlSoLuongTonfromDB().FirstOrDefault(p => p.size == cb_Size.Text);
            if (update != null)
            {
                //update.size = cb_Size.Text;
                update.soluongtonn = Convert.ToInt32(tbt_SoLuongCon.Text);
                _QLSLton.updateSoLuongTon(update);
                var layma = _QLSLton.getViewSLton().Where(p => p.sanPhams.maSanPham == tbt_MaSP.Text);
                dtgv_slton.Rows.Clear();
                foreach (var item in layma)
                {

                    dtgv_slton.Rows.Add(item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn);
                }
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã sản phẩm");
            }
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            //tbt_MaSP.Enabled = false;
            //tbt_TimMa.Enabled = true;
            //tbt_TimTen.Enabled = true;
            tbt_MaSP.Clear();
            tbt_TenSP.Clear();
            cb_Size.SelectedIndex = -1;
            tbt_SoLuongCon.Clear();
            tbt_GiaBan.Clear();
            tbt_TimMa.Clear();
            tbt_TimTen.Clear();
            rb_ConHang.Checked = true;
            ptb_Avatar.Image = null;
        }

        private void btn_TimTen_Click(object sender, EventArgs e)
        {
            var timKiem = _QLSanPham.getlSanPhamfromDB().Where(p => p.maSanPham.Contains(tbt_TimMa.Text));
            if (timKiem.Count() < 1)
            {
                dtgv_SanPham.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtgv_SanPham.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtgv_SanPham.Rows.Add(item.maSanPham, item.tenSanPham, item.giaBan, item.tinhTrang == true ? "Còn hàng" : "hết hàng",
                        item.size, item.soLuong);
                }
                lbl_Tong.Text = "Tổng số sản phẩm: " + dtgv_SanPham.Rows.Count;
            }
        }

        private void btn_TimMa_Click(object sender, EventArgs e)
        {
            var timKiem = _QLSanPham.getlSanPhamfromDB().Where(p => p.tenSanPham.Contains(tbt_TimTen.Text));
            if (timKiem.Count() < 1)
            {
                dtgv_SanPham.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtgv_SanPham.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtgv_SanPham.Rows.Add(item.maSanPham, item.tenSanPham, item.giaBan, item.tinhTrang == true ? "Còn hàng" : "hết hàng",
                        item.size, item.soLuong);
                }
                lbl_Tong.Text = "Tổng số sản phẩm: " + dtgv_SanPham.Rows.Count;
            }

        }

        private void dtgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_SanPham.Rows[e.RowIndex];
            
            tbt_MaSP.Text = row.Cells[0].Value.ToString();
            tbt_TenSP.Text = row.Cells[1].Value.ToString();
            tbt_GiaBan.Text = row.Cells[2].Value.ToString();
            rb_ConHang.Checked = row.Cells[3].Value.ToString() == "Còn hàng" ? true : false;
            rb_HetHang.Checked = row.Cells[3].Value.ToString() == "Hết hàng" ? true : false;
            var laylinkanh = _QLSanPham.getlSanPhamfromDB().Where(p => p.maSanPham.ToString()
            == tbt_MaSP.Text).Select(p => p.hinhAnh).FirstOrDefault();
            Image image = Image.FromFile(laylinkanh);
            linkanh = laylinkanh;
            ptb_Avatar.Image = image;
            ptb_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            var layma = _QLSLton.getViewSLton().Where(p => p.sanPhams.maSanPham == row.Cells[0].Value.ToString());
            dtgv_slton.Rows.Clear();
            foreach (var item in layma)
            {
                
                dtgv_slton.Rows.Add(item.sanPhams.tenSanPham, item.SoLuongTons.size, item.SoLuongTons.soluongtonn);
            }
            loadDuLieu();


        }

        private void dtgv_slton_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_slton.Rows[e.RowIndex];
            cb_Size.Text = row.Cells[1].Value.ToString();
            tbt_SoLuongCon.Text = row.Cells[2].Value.ToString();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var update = _QLSanPham.getlSanPhamfromDB().FirstOrDefault(p => p.maSanPham == tbt_MaSP.Text);
            if (update != null)
            {
                update.tenSanPham = tbt_TenSP.Text;
                update.giaBan = Convert.ToInt32(tbt_GiaBan.Text);
                update.tinhTrang = rb_ConHang.Checked;
                update.hinhAnh = linkanh;
                _QLSanPham.updateSanPham(update);
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã sản phẩm");
            }

        }
    }
}
