using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI.ChucNang
{
    public partial class FromHoaDonNhap : Form
    {
        public FromHoaDonNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromCchiTietHoaDonNhap CTHDnhap = new FromCchiTietHoaDonNhap();
            CTHDnhap.ShowDialog();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
