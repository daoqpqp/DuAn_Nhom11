using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using EasyXLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.FmNhanVien
{
    public partial class FmDSNhanVien : Form
    {
        IQuanLyNhanVien _QLNhanVien;
        public FmDSNhanVien()
        {
            InitializeComponent();
            _QLNhanVien = new QuanLyNhanVien();
            LoadData();
        }
        public void LoadData()
        {
            dtg_Show.Rows.Clear();
            foreach (var item in _QLNhanVien.getlNhanVienfromDB())
            {
                dtg_Show.Rows.Add(item.maNV, item.TenNV, item.gioiTinh == true ? "Nam" : "Nữ", item.soDienThoai, item.diaChi,
                    item.chucVu == true ? "Quản trị" : "Nhân viên", item.matKhau);
            }
            lb_ThongKe.Text = "Tổng số nhân viên: " + dtg_Show.Rows.Count;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            NhanVien accNV = _QLNhanVien.getlNhanVienfromDB().FirstOrDefault
              (p => p.maNV == tbt_ma.Text);
            double sl;
            bool check1 = double.TryParse(tbt_SDT.Text, out sl);
            if (tbt_ma.Text == "" || tbt_Ten.Text == "" ||
                 tbt_SDT.Text == "" || tbt_DiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accNV != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                tbt_ma.Text = "";
            }else if (check1 == false || tbt_SDT.Text.Length != 10)
            {
                MessageBox.Show("số điện thoại phải là số và có 10 ký tự");
            }
            else
            {
                NhanVien nv = new NhanVien()
                {
                    maNV = tbt_ma.Text,
                    TenNV = tbt_Ten.Text,
                    gioiTinh = rb_nam.Checked,
                    soDienThoai = tbt_SDT.Text,
                    diaChi = tbt_DiaChi.Text,
                    chucVu = rb_quanTri.Checked,
                    matKhau = tbt_ma.Text

                };
                _QLNhanVien.addNhanVien(nv);
                MessageBox.Show("Thêm nhân viên thành công");
                LoadData();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
            string fileName = "";
            fileName = dlg.FileName;
            try
            {
                // Tạo một thể hiện của lớp xuất các tệp excel, có một tờ
                ExcelDocument workbook = new ExcelDocument(1);
                ExcelWorksheet xlsWorksheet = (ExcelWorksheet)workbook.easy_getSheetAt(0);
                xlsWorksheet.setSheetName("DataGridView");
                // Nhận bảng bảng lưu trữ dữ liệu
                ExcelTable xlsTable = xlsWorksheet.easy_getExcelTable();
                int tableRow = 0;
                // Xuất tiêu đề DataGridView nếu tiêu đề hiển thị
                if (dtg_Show.ColumnHeadersVisible)
                {
                    // Tạo kiểu định dạng cho tiêu đề
                    ExcelStyle xlsStyleHeader = new ExcelStyle();
                    xlsStyleHeader.setBackground(dtg_Show.ColumnHeadersDefaultCellStyle.BackColor);
                    xlsStyleHeader.setForeground(dtg_Show.ColumnHeadersDefaultCellStyle.ForeColor);

                    // Thêm dữ liệu trong các ô để tiêu đề
                    for (int column = 0; column < dtg_Show.Columns.Count; column++)
                    {
                        xlsTable.easy_getCell(tableRow, column).setValue(
                                              dtg_Show.Columns[column].HeaderText);
                        xlsTable.easy_getCell(tableRow, column).setStyle(xlsStyleHeader);
                    }
                    tableRow++;
                }

                // Tạo kiểu định dạng cho các ô
                ExcelStyle xlsStyleCell = new ExcelStyle();
                xlsStyleCell.setBackground(dtg_Show.DefaultCellStyle.BackColor);
                xlsStyleCell.setForeground(dtg_Show.DefaultCellStyle.ForeColor);
                // Thêm dữ liệu trong các ô
                for (int row = 0; row < dtg_Show.Rows.Count - 1; row++)
                {
                    for (int column = 0; column < dtg_Show.Columns.Count; column++)
                    {
                        xlsTable.easy_getCell(tableRow, column).setValue(
                                              dtg_Show.Rows[row].Cells[column].Value.ToString());
                        xlsTable.easy_getCell(tableRow, column).setStyle(xlsStyleCell);
                    }
                    tableRow++;
                }

                // Export Excel file
                workbook.easy_WriteXLSXFile(fileName);

                MessageBox.Show("Xuất file thành công");
            }
            catch (Exception EE)
            {
                MessageBox.Show("Có lỗi khi lưu file!  " + EE);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            var update = _QLNhanVien.getlNhanVienfromDB().FirstOrDefault(p => p.maNV == tbt_ma.Text);
            if (update != null)
            {
                update.TenNV = tbt_Ten.Text;
                update.gioiTinh = rb_nam.Checked;
                update.soDienThoai = tbt_SDT.Text;
                update.diaChi = tbt_DiaChi.Text;
                update.chucVu = rb_quanTri.Checked;
                _QLNhanVien.updateNhanVien(update);
                MessageBox.Show("sửa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã nhân viên");
            }
                
        }

        private void btn_lamMoi_Click(object sender, EventArgs e)
        {
            tbt_ma.Clear();
            tbt_Ten.Clear();
            rb_nam.Checked = true;
            tbt_SDT.Clear();
            tbt_DiaChi.Clear();
            tbt_TimMa.Clear();
            tbt_timTen.Clear();
            rb_quanTri.Checked = true;
        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtg_Show.Rows[e.RowIndex];
            tbt_ma.Text = row.Cells[0].Value.ToString();
            tbt_Ten.Text = row.Cells[1].Value.ToString();
            rb_nam.Checked = row.Cells[2].Value.ToString() == "Nam" ? true : false;
            rb_nu.Checked = row.Cells[2].Value.ToString() == "Nữ" ? true : false;
            tbt_SDT.Text = row.Cells[3].Value.ToString();
            tbt_DiaChi.Text = row.Cells[4].Value.ToString();
            rb_quanTri.Checked = row.Cells[5].Value.ToString() == "Quản trị" ? true : false;
            rb_NhanVien.Checked = row.Cells[5].Value.ToString() == "Nhân viên" ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var timKiem = _QLNhanVien.getlNhanVienfromDB().Where(p => p.maNV.Contains(tbt_TimMa.Text));
            if (timKiem.Count() < 1)
            {
                dtg_Show.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtg_Show.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtg_Show.Rows.Add(item.maNV, item.TenNV, item.gioiTinh == true ? "Nam" : "Nữ", item.soDienThoai, item.diaChi,
                        item.chucVu == true ? "Quản trị" : "Nhân viên", item.matKhau);
                }
                lb_ThongKe.Text = "Tổng số nhân viên: " + dtg_Show.Rows.Count;
            }
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var timKiem = _QLNhanVien.getlNhanVienfromDB().Where(p => p.TenNV.Contains(tbt_timTen.Text));
            if (timKiem.Count() < 1)
            {
                dtg_Show.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtg_Show.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtg_Show.Rows.Add(item.maNV, item.TenNV, item.gioiTinh == true ? "Nam" : "Nữ", item.soDienThoai, item.diaChi,
                        item.chucVu == true ? "Quản trị" : "Nhân viên", item.matKhau);
                }
                lb_ThongKe.Text = "Tổng số nhân viên: " + dtg_Show.Rows.Count;
            }
        }
    }
}
