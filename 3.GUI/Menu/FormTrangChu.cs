using _3.GUI.ChucNang;
using _3.GUI.FmHoaDon;
using _3.GUI.FmKhachHang;
using _3.GUI.FmNhaCungCap;
using _3.GUI.FmNhanVien;
using _3.GUI.FmSanPham;
using _3.GUI.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.TrangChu
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            GoFullscreen(AutoSize);
            button3.Visible = false;
            button2.Visible = false;
            button6.Visible = false;
            button5.Visible = false;
            button9.Visible = false;
            button8.Visible = false;
            button12.Visible = false;
            button11.Visible = false;
            button16.Visible = false;
            button15.Visible = false;
            button17.Visible = false;
            button14.Visible = false;
            button19.Visible = false;
            button21.Visible = false;
            button20.Visible = false;
        }
        public void GiaoDienNV()
        {
            button13.Visible = false;
            button18.Visible = false;
            button20.Visible = false;
        }

        private Form currenform;
        public void Openchildform(Form childform)
        {
            if (currenform != null)
            {
                currenform.Close();
            }
            currenform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_hienthi.Controls.Add(childform);
            panel_hienthi.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.Visible == true)
            {
                
                button2.Visible = false;
            }
            else
            {
                
                button2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button5.Visible == true)
            {
                //button6.Visible = false;
                button5.Visible = false;
            }
            else
            {
                //button6.Visible = true;
                button5.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button8.Visible == true)
            {
                button9.Visible = false;
                button8.Visible = false;
            }
            else
            {
                button9.Visible = true;
                button8.Visible = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button11.Visible == true)
            {
                button12.Visible = false;
                button11.Visible = false;
            }
            else
            {
                button12.Visible = true;
                button11.Visible = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button16.Visible == true)
            {
                button16.Visible = false;
                button15.Visible = false;
                button17.Visible = false;
                //button14.Visible = false;
            }
            else
            {
                button16.Visible = true;
                button15.Visible = true;
                button17.Visible = true;
                //button14.Visible = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button19.Visible == true)
            {
                button19.Visible = false;
                
            }
            else
            {
                button19.Visible = true;
                
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button21.Visible == true)
            {
                button21.Visible = false;

            }
            else
            {
                button21.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDanhSachKH());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Openchildform(new FromHoaDonNhap());
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Openchildform(new FmHoaDonDaBan());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Openchildform(new FmHoaDonDaNhap());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDanhSachKH());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDanhSachKHThanThiet());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Openchildform(new Form1());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDanhSachSPton());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Openchildform(new FromHoaDonNhapTheoNgay());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Openchildform(new FromHoaDonBanTheoNgay());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Openchildform(new FromHoaDonBanTheoNgay());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Openchildform(new FromDoanhThu());

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDSNhanVien());

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Openchildform(new FmDSnhaCungCap());
        }
        private void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
    }
}
