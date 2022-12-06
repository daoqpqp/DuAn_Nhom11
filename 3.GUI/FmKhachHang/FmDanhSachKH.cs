using _1.DAL.DomainModels;
using _2.BUS.IServices;
using _2.BUS.Services;
using _3.GUI.ChucNang;
using _3.GUI.TrangChu;
using System.Data;

namespace _3.GUI.FmKhachHang
{
    public partial class FmDanhSachKH : Form
    {
        public static string MaHD1 = "";
        public static string hoTen = "";
        public static string SDT = "";
        public static string dc = "";
        double sl;
        IQuanLyHoaDonBan _QLHDBan;
        IQuanLyKhachHang _IQLKhachHang;
        public FmDanhSachKH()
        {
            InitializeComponent();
            _IQLKhachHang = new QuanLyKhachHang();
            _QLHDBan = new QuanLyHoaDonBan();

            loadDuLieu();
        }
        public void loadDuLieu()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in _IQLKhachHang.getlKhachHangfromDB())
            {
                dataGridView1.Rows.Add(item.SDT_KH, item.tenKH, item.diaChi_KH);
            }
            label6.Text = "Tổng số Khách Hàng: " + (dataGridView1.Rows.Count - 1);
        }
        public bool validate()
        {
            if (tbt_sdt.Text == "" || tbt_hoten.Text == "" || tbt_dc.Text == "")
            {
                MessageBox.Show("bạn để trống thông tin");
                return false;
            }

            bool check1 = double.TryParse(tbt_sdt.Text, out sl);
            if (check1 == false || tbt_sdt.Text.Length != 10)
            {
                MessageBox.Show("số điện thoại phải là số và có 10 ký tự");
                return false;
            }
            return true;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                hoTen = tbt_hoten.Text;
                SDT = tbt_sdt.Text;
                dc = tbt_dc.Text;
                HoaDonBan hd = new HoaDonBan()
                {

                    maHD = Convert.ToString(_QLHDBan.getlHoaDonBanfromDB().Count + 1),
                    maNV = Properties.Settings.Default.tk,
                    ngayban = DateTime.Now,
                    SDT_KH = tbt_sdt.Text,
                    trangThaiBan = false
                };
                _QLHDBan.addHoaDonBan(hd);
                MaHD1 = hd.maHD;
                //MessageBox.Show(MaHD1);
                FromHoaDonBan hdb = new FromHoaDonBan();
                hdb.ShowDialog();
                //this.Close();
                //FormTrangChu tt = new FormTrangChu();
                //tt.Openchildform(new FromHoaDonBan());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var update = _IQLKhachHang.getlKhachHangfromDB().FirstOrDefault(p => p.SDT_KH == tbt_sdt.Text);
            update.tenKH = tbt_hoten.Text;
            update.diaChi_KH = tbt_dc.Text;
            _IQLKhachHang.updateKhachHang(update);
            loadDuLieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var timkiem = _IQLKhachHang.getlKhachHangfromDB().Where(p => p.tenKH.Contains(tbt_timkiem_ten.Text));
            dataGridView1.Rows.Clear();
            foreach (var item in timkiem)
            {
                dataGridView1.Rows.Add(item.SDT_KH, item.tenKH, item.diaChi_KH);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var timkiem1 = _IQLKhachHang.getlKhachHangfromDB().Where(p => p.SDT_KH.Contains(tbt_timkiem_sdt.Text));
            dataGridView1.Rows.Clear();
            foreach (var item in timkiem1)
            {
                dataGridView1.Rows.Add(item.SDT_KH, item.tenKH, item.diaChi_KH);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var item = _IQLKhachHang.getlKhachHangfromDB().Where(p => p.SDT_KH == tbt_sdt.Text).FirstOrDefault();
                if (item != null)
                {
                    MessageBox.Show("Khách hàng đã tồn tại");

                }
                else
                {

                    KhachHang kh = new KhachHang()
                    {
                        SDT_KH = tbt_sdt.Text,
                        tenKH = tbt_hoten.Text,
                        diaChi_KH = tbt_dc.Text
                    };
                    _IQLKhachHang.addKhachHang(kh);
                    MessageBox.Show("Thêm thành công");
                    loadDuLieu();

                }
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Close();

            MessageBox.Show(Properties.Settings.Default.tk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            tbt_sdt.Text = row.Cells[0].Value.ToString();
            tbt_hoten.Text = row.Cells[1].Value.ToString();
            tbt_dc.Text = row.Cells[2].Value.ToString();
        }
    }
}
