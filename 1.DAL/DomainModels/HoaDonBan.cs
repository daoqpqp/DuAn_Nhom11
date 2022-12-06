using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("HoaDonBan")]
    public partial class HoaDonBan
    {
       
        public HoaDonBan()
        {

        }
        [Key]
        public string maHD { get; set; } = default!;
        public DateTime ngayban { get; set; }
        public string maNV { get; set; } = default!;
        [ForeignKey("maNV")]
        public NhanVien IDnhanVien { get; set; } = default!;
        public string SDT_KH { get; set; } = default!;
        [ForeignKey("SDT_KH")]
        public KhachHang IDkhachHang { get; set; } = default!;
        public bool trangThaiBan { get; set; }

        public ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; } = default!;

    }
}
