using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            
        }
        [Key]
        public string maNV { get; set; } = default!;
        [StringLength(100)]
        public string TenNV { get; set; } = default!;
        [StringLength(500)]
        public string diaChi { get; set; } = default!;
        [StringLength(20)]
        public string soDienThoai { get; set; } = default!;
        [StringLength(20)]
        public string matKhau { get; set; } = default!;
        public bool chucVu { get; set; }  
        public bool gioiTinh { get; set; }
        public ICollection<HoaDonBan> HoaDonNhaps { get; set; } = default!;
        public ICollection<hoaDonNhap> HoaDonBans { get; set; } = default!;



    }
}
