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
    [Table("SoLuongTon")]
    public partial class SoLuongTon
    {
        public SoLuongTon()
        {
        }
        [Key]
        [Column(Order = 1)]
        public string maSanPham { get; set; }
        [Key]
        [Column(Order = 2)]
        public string size { get; set; }
        public int soluongtonn { get; set; }
        [ForeignKey("maSanPham")]
        public SanPham SanPham { get; set; } = default!;
        
        
    }
}
