using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.Menu
{
    public partial class Fmlogin : Form
    {
        IQuanLyNhanVien _QLNhanVien;
        public Fmlogin()
        {
            InitializeComponent();
            _QLNhanVien= new QuanLyNhanVien();
            tbt_TaiKhoan.Text = Properties.Settings.Default.tk;
            tbt_MatKhau.Text = Properties.Settings.Default.mk;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien accNV = _QLNhanVien.getlNhanVienfromDB().FirstOrDefault
               (p => p.maNV == tbt_TaiKhoan.Text && p.matKhau == tbt_MatKhau.Text);
            if (tbt_TaiKhoan.Text == "" || tbt_MatKhau.Text == "")
            {
                MessageBox.Show("Tài khoản mật khẩu không được để trống");
            }
            else
            {
                Properties.Settings.Default.tk = tbt_TaiKhoan.Text;
                Properties.Settings.Default.mk = tbt_MatKhau.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Đăng nhập thành công");
                FormTrangChu main = new FormTrangChu();
                //this.Visible = false;
                string tKhoan = Properties.Settings.Default.tk;
                var layVaiTro = _QLNhanVien.getlNhanVienfromDB().Where(p => p.maNV == tKhoan).
                        Select(p => p.chucVu).FirstOrDefault();
                if (layVaiTro == false)
                {
                    MessageBox.Show("Bạn đã đăng nhập với tư cách nhân viên");
                    main.GiaoDienNV();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn đã đăng nhập với tư cách quản lý");
                    main.ShowDialog();
                }
            }

            if (cb_NhoMK.Checked == true)
            {
                Properties.Settings.Default.tk = tbt_TaiKhoan.Text;
                Properties.Settings.Default.mk = tbt_MatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tk = "";
                Properties.Settings.Default.mk = "";
                Properties.Settings.Default.Save();
            }
        }
    }
}
