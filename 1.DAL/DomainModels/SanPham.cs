using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("SanPham")]
    public partial class SanPham
    {
        public SanPham()
        {
            //HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }
        [Key]
        [Column("maSanPham")]
        public string maSanPham { get; set; } = default!;
        [StringLength(100)]
        public string tenSanPham { get; set; } = default!;
        //public float giaNhap { get; set; }
        public float giaBan { get; set; }
        public bool tinhTrang { get; set; }
        
        [StringLength(500)]
        public string hinhAnh { get; set; } = default!;
        public int soLuong { get; set; }
        public float size { get; set; }
      
        public ICollection<ChiTietHoaDonBan> ChiTietHoaDonBans { get; set; } = default!;
        public ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; } = default!;
        public ICollection<SoLuongTon> soLuongTons { get; set; } = default!;
    }
}
