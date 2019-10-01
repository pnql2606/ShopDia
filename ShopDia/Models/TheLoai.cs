using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopDia.Models
{
    public class TheLoai
    {
        [ScaffoldColumn(false)]
        [Key]
        public int MaTL { get; set; }
        [Required, StringLength(100), Display(Name = "Tên")]
        public string TenTL { get; set; }
        public virtual ICollection<Album> Albums { get; set; }
    }
}