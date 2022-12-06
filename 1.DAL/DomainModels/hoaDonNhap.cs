using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("hoaDonNhap")]
    public partial class hoaDonNhap
    {
        public hoaDonNhap()
        {

        }
        [Key]
        public string maHoaDonNhap { get; set; } = default!;
        public DateTime ngayNhap { get; set; }
        
        public string maNhaCungCap { get; set; } = default!;
        [ForeignKey("maNhaCungCap")]
        public nhaCungCap NhaCungCaps { get; set; } = default!;
        public string maNV { get; set; } = default!;

        [ForeignKey("maNV")]
        public NhanVien nhanViens { get; set; } = default!;
        public ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = default!;
    }
}
