using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace _1.DAL.DomainModels
{
    [Table("ChiTietHoaDonBan")]
    public partial class ChiTietHoaDonBan
    {

        public ChiTietHoaDonBan()
        {

        }
        [Key]
        [Column(Order = 1)]
        public string maHD { get; set; } = default!;

        [Key]
        [Column(Order = 2)]
        public string maSanPham { get; set; } = default!;
        public int soLuongBan { get; set; }
        public int giaBan { get; set; }
        public string Size { get; set; }
        public int tongTienBan { get; set; } 
        [ForeignKey("maHD")]
        public HoaDonBan HoaDonBan { get; set; }= default!;
        [ForeignKey("maSanPham")]
        public SanPham SanPham { get; set; } = default!;


    }
}
