using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            //HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public string SDT_KH { get; set; } = default!;
        [StringLength(200)]
        public string tenKH { get; set; } = default!;
        [StringLength(200)]
        public string diaChi_KH { get; set; } = default!;
        public ICollection<HoaDonBan> HoaDonBans { get; set; } = default!;


    }
}
