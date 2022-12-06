using _3.GUI.ChucNang;
using _3.GUI.FmKhachHang;
using _3.GUI.FmNhaCungCap;
using _3.GUI.FmNhanVien;
using _3.GUI.FmSanPham;
using _3.GUI.Menu;
using _3.GUI.ThongKe;
using _3.GUI.TrangChu;

namespace _3.GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormTrangChu());
        }
    }
}