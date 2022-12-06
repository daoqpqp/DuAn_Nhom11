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


namespace _3.GUI.FmNhaCungCap
{
    public partial class FmDSnhaCungCap : Form
    {
        IQuanLynhaCungCap _IQLNhaCungCap;

        public FmDSnhaCungCap()
        {
            
            InitializeComponent();
            _IQLNhaCungCap = new QuanLynhaCungCap();
            loadDuLieu();

        }
        public void loadDuLieu()
        {
            dtgv_NCC.Rows.Clear();
            foreach (var item in _IQLNhaCungCap.getlnhaCungCapfromDB())
            {
                dtgv_NCC.Rows.Add(item.maNhaCungCap, item.tenNhaCungCap, item.SDT_NCC, item.diaChiNCC,
                    item.tinhTrang == true ? "Hoạt động" : "KHĐ");
            }
            lblThongKe.Text = "Tổng số nhà cung cấp: " + dtgv_NCC.Rows.Count;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            nhaCungCap accNCC = _IQLNhaCungCap.getlnhaCungCapfromDB().FirstOrDefault
              (p => p.maNhaCungCap == tbt_maNCC.Text);
            double sl;
            bool check1 = double.TryParse(tbt_SDT.Text, out sl);
            if (tbt_maNCC.Text == "" || tbt_tenNCC.Text == "" ||
                 tbt_SDT.Text == "" || tbt_DiaChi.Text == "")
            {
                MessageBox.Show("Không được để trống thông tin");
            }
            else if (accNCC != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                tbt_maNCC.Text = "";
            }
            else if (check1 == false || tbt_SDT.Text.Length != 10)
            {
                MessageBox.Show("số điện thoại phải là số và có 10 ký tự");
            }
            else
            {
                nhaCungCap ncc = new nhaCungCap()
                {
                    maNhaCungCap = tbt_maNCC.Text,
                    tenNhaCungCap = tbt_tenNCC.Text,
                    SDT_NCC = tbt_SDT.Text,
                    diaChiNCC = tbt_DiaChi.Text,
                    tinhTrang = rb_HoatDong.Checked,
                };
                _IQLNhaCungCap.addnhaCungCap(ncc);
                MessageBox.Show("Thêm nhà cung cấp thành công");
                loadDuLieu();
            }
                
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var update = _IQLNhaCungCap.getlnhaCungCapfromDB().FirstOrDefault(p => p.maNhaCungCap == tbt_maNCC.Text);
            if (update != null)
            {
                update.tenNhaCungCap = tbt_tenNCC.Text;
                update.SDT_NCC = tbt_SDT.Text;
                update.diaChiNCC = tbt_DiaChi.Text;
                update.tinhTrang = rb_HoatDong.Checked;
                _IQLNhaCungCap.updatenhaCungCap(update);
                MessageBox.Show("sửa thành công");
                loadDuLieu();
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mã nhà cung cấp");
            }
               
        }

        private void dtgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgv_NCC.Rows[e.RowIndex];
            tbt_maNCC.Text = row.Cells[0].Value.ToString();
            tbt_tenNCC.Text = row.Cells[1].Value.ToString();
            tbt_SDT.Text = row.Cells[2].Value.ToString();
            tbt_DiaChi.Text = row.Cells[3].Value.ToString();
            rb_HoatDong.Checked = row.Cells[4].Value.ToString() == "Hoạt động" ? true : false;
            rb_KHD.Checked = row.Cells[4].Value.ToString() == "KHĐ" ? true : false;
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            tbt_maNCC.Clear();
            tbt_tenNCC.Clear();
            tbt_SDT.Clear();
            tbt_DiaChi.Clear();
            tbt_TimMa.Clear();
            tbt_TimTen.Clear();
            rb_HoatDong.Checked = true;
        }

        private void btn_TimMa_Click(object sender, EventArgs e)
        {
            var timKiem = _IQLNhaCungCap.getlnhaCungCapfromDB().Where(p => p.maNhaCungCap.Contains(tbt_TimMa.Text));
            if (timKiem.Count() < 1)
            {
                dtgv_NCC.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtgv_NCC.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtgv_NCC.Rows.Add(item.maNhaCungCap, item.tenNhaCungCap, item.SDT_NCC, item.diaChiNCC,
                        item.tinhTrang == true ? "Hoạt động" : "KHĐ");
                }
            }
        }

        private void btn_TimTen_Click(object sender, EventArgs e)
        {
            var timKiem = _IQLNhaCungCap.getlnhaCungCapfromDB().Where(p => p.tenNhaCungCap.Contains(tbt_TimTen.Text));
            if (timKiem.Count() < 1)
            {
                dtgv_NCC.Rows.Clear();
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                dtgv_NCC.Rows.Clear();
                foreach (var item in timKiem)
                {
                    dtgv_NCC.Rows.Add(item.maNhaCungCap, item.tenNhaCungCap, item.SDT_NCC, item.diaChiNCC,
                        item.tinhTrang == true ? "Hoạt động" : "KHĐ");
                }
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
                if (dtgv_NCC.ColumnHeadersVisible)
                {
                    // Tạo kiểu định dạng cho tiêu đề
                    ExcelStyle xlsStyleHeader = new ExcelStyle();
                    xlsStyleHeader.setBackground(dtgv_NCC.ColumnHeadersDefaultCellStyle.BackColor);
                    xlsStyleHeader.setForeground(dtgv_NCC.ColumnHeadersDefaultCellStyle.ForeColor);

                    // Thêm dữ liệu trong các ô để tiêu đề
                    for (int column = 0; column < dtgv_NCC.Columns.Count; column++)
                    {
                        xlsTable.easy_getCell(tableRow, column).setValue(
                                              dtgv_NCC.Columns[column].HeaderText);
                        xlsTable.easy_getCell(tableRow, column).setStyle(xlsStyleHeader);
                    }
                    tableRow++;
                }

                // Tạo kiểu định dạng cho các ô
                ExcelStyle xlsStyleCell = new ExcelStyle();
                xlsStyleCell.setBackground(dtgv_NCC.DefaultCellStyle.BackColor);
                xlsStyleCell.setForeground(dtgv_NCC.DefaultCellStyle.ForeColor);
                // Thêm dữ liệu trong các ô
                for (int row = 0; row < dtgv_NCC.Rows.Count - 1; row++)
                {
                    for (int column = 0; column < dtgv_NCC.Columns.Count; column++)
                    {
                        xlsTable.easy_getCell(tableRow, column).setValue(
                                              dtgv_NCC.Rows[row].Cells[column].Value.ToString());
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
    }
}
