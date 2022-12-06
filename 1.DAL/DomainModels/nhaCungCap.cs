using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _1.DAL.DomainModels
{
    [Table("nhaCungCap")]
    public partial class nhaCungCap
    {
        public nhaCungCap()
        {

        }
        [Key]
        [Column("maNhaCungCap")]
        public string maNhaCungCap { get; set; } = default!;
        [Required]
        [StringLength(100)]
        public string tenNhaCungCap { get; set; } = default!;
        public string SDT_NCC { get; set; }
        [StringLength(500)]
        public string diaChiNCC { get; set; } = default!;
        public bool tinhTrang { get; set; }
        public ICollection<hoaDonNhap> HoaDonNhaps { get; set; } = default!;

    }
}
