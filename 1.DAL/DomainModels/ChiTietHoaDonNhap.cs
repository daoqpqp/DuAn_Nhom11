using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("ChiTietHoaDonNhap")]
    public class ChiTietHoaDonNhap
    {
        public ChiTietHoaDonNhap()
        {

        }
        [Key]
        [Column(Order = 1)]
        public string maSanPham { get; set; } = default!;

        [Key]
        [Column(Order = 2)]
        public string maHoaDonNhap { get; set; } = default!;
        public int SoLuongNhap { get; set; }
        public float donGiaNhap { get; set; }
        public float tongTienNhap { get; set; }
        [ForeignKey("maHoaDonNhap")]
        public hoaDonNhap hoaDonNhap { get; set; } = default!;
        [ForeignKey("maSanPham")]
        public SanPham SanPham { get; set; } = default!;

    }
}
