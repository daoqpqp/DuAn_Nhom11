using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.FmKhachHang;
using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.ChucNang
{
    public partial class FromChiTietHoaDonBan : Form
    {
        IQuanLyChiTietHoaDonBan _IQLChiTietHoaDonBan;
        IQuanLyHoaDonBan _QLHDBan;
        public FromChiTietHoaDonBan()
        {

            InitializeComponent();
            _QLHDBan = new QuanLyHoaDonBan();
            tbt_maHD.Text = FromHoaDonBan.maHD;
            //tbt_nguoiLap.Text = FromHoaDonBan.nguoiLap;
            dateTimePicker1.Value = FromHoaDonBan.ngayLap;
            tbt_tongTien.Text = FromHoaDonBan.tongTien;
            tbt_ten.Text = FmDanhSachKH.hoTen;
            tbt_dc.Text = FmDanhSachKH.dc;
            tbt_sdt.Text = FmDanhSachKH.SDT;
            _IQLChiTietHoaDonBan = new QuanLyChiTietHoaDonBan();
            var x = _IQLChiTietHoaDonBan.getlChiTietHoaDonBanfromDB().Where(p => p.maHD == tbt_maHD.Text);
            foreach (var item in x)
            {
                dgv_ct.Rows.Add(item.maSanPham, item.Size, item.soLuongBan, item.giaBan, item.tongTienBan);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void InHoaDon()
        {
            try
            {
                Document doc = new Document();// Tạo đối tượng tài liệu (Document)
                Paragraph paragraph = doc.AddSection().AddParagraph();
                Spire.Doc.Fields.TextRange text = paragraph.AppendText("\n\t\t\t\tHóa đơn chi tiết");
                text.CharacterFormat.Bold = true;                                   // kiểu in đậm
                paragraph.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                                                                                    //paragraph.Format.HorizontalAlignment = Element.ALIGN_CENTER;  // đoạn canh giữa
                ParagraphStyle style = new ParagraphStyle(doc);
                text.CharacterFormat.Italic = true;
                style.Name = "FontStyle";
                style.CharacterFormat.FontName = "UVN Nhat Ky";
                style.CharacterFormat.FontSize = 25;                    // kích thước 30
                doc.Styles.Add(style);
                paragraph.ApplyStyle(style.Name);


                // đoạn mới tên biến là  Mã hóa đơn
                Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text2 = paragraph2.AppendText("\n\t\tMã hóa đơn: " + tbt_maHD.Text + "\t\t\t" + "Tên khách hàng: " + tbt_ten.Text);
                text2.CharacterFormat.Italic = true;
                text2.CharacterFormat.FontSize = 14;
                text2.CharacterFormat.Bold = true;


                // đoạn mới tên biến là  Thông tin hóa đơn
                Paragraph paragraph4 = doc.Sections[0].AddParagraph();
                paragraph2.Format.Tabs.AddTab(100).Justification = TabJustification.Right;
                paragraph2.Format.Tabs.AddTab(100).Justification = TabJustification.Left;
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text4 = paragraph4.AppendText("\t\t\tNgày lập: " + dateTimePicker1.Text + "\t\t" + "Địa chỉ: " + tbt_dc.Text);
                text4.CharacterFormat.FontSize = 14;
                text4.CharacterFormat.Bold = true;
                text4.CharacterFormat.Italic = true;


                // đoạn mới tên biến là  Thông tin hóa đơn
                Paragraph paragraph6 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text6 = paragraph6.AppendText("\t\t\t\t\t\t\t\tSố điện thoại: " + tbt_sdt.Text + "\n");
                text6.CharacterFormat.FontSize = 14;
                text6.CharacterFormat.Bold = true;
                text6.CharacterFormat.Italic = true;


                // đoạn mới tên biến là  Thông tin hóa đơn
                Paragraph paragraph10 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text10 = paragraph10.AppendText("\t" + "Mã sản phẩm" + "\t\t" + "Size" + "\t" + "Số lượng bán" + "\t\t" + "Giá Bán" + "\t" + "Tổng tiền bán");
                text10.CharacterFormat.FontSize = 12;
                text10.CharacterFormat.Bold = true;
                text10.CharacterFormat.Italic = true;


                var x = _IQLChiTietHoaDonBan.getlChiTietHoaDonBanfromDB().Where(p => p.maHD == tbt_maHD.Text);
                foreach (var item in x)
                {

                    // đoạn mới tên biến là  Thông tin hóa đơn
                    Paragraph paragraph11 = doc.Sections[0].AddParagraph();
                    // tên văn bản mới là text2
                    Spire.Doc.Fields.TextRange text11 = paragraph11.AppendText("\t\t" + item.maSanPham + "\t\t" + item.Size + "\t\t" + item.soLuongBan + "\t\t" + item.giaBan + "\t\t" + item.tongTienBan);
                    text11.CharacterFormat.FontSize = 12;
                    text11.CharacterFormat.Bold = true;
                    text11.CharacterFormat.Italic = true;
                }

                // đoạn mới tên biến là  Thông tin hóa đơn
                Paragraph paragraph15 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text15 = paragraph15.AppendText("\n\n" + "\t\t" + "Thành tiền: " + tbt_tongTien.Text);
                text15.CharacterFormat.Bold = true;
                text15.CharacterFormat.Bold = true;
                text15.CharacterFormat.Italic = true;

                // Lưu đối tượng tài liệu vào tập tin test.doc (nằm ở thư mục Debug của dự án)
                doc.SaveToFile("vvvv.doc", Spire.Doc.FileFormat.Doc);
                MessageBox.Show("In hóa đơn thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception EE)
            {
                MessageBox.Show("Lỗi" + EE);
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thanh toán không?",
                    "...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HoaDonBan hhs = (from a in _QLHDBan.getlHoaDonBanfromDB()
                                 where a.maHD == tbt_maHD.Text
                                 select a).FirstOrDefault();
                hhs.trangThaiBan = true;
                _QLHDBan.updateHoaDonBan(hhs);
                //MessageBox.Show("đã sửa");
                DialogResult dialogResult2 = MessageBox.Show("Bạn có muốn in hóa đơn không?",
                    "...", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    InHoaDon();
                }
                this.Close();
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            FmThanhToanQR thanhTOan = new FmThanhToanQR();
            this.Visible = false;
            thanhTOan.ShowDialog();
        }
    }
}
