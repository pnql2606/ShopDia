using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ShopDia.Models
{
    public class Album
    {
        [ScaffoldColumn(false)]
        [Key]
        public int MaDia { get; set; }
        [Required, StringLength(100), Display(Name = "Tên")]
        public string TenDia { get; set; }
        [Required, StringLength(1000), Display(Name = "Mô tả"),
        DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
        [Display(Name = "Gia")]
        public float? Gia { get; set; }
        public int? MaTL { get; set; }
        public virtual TheLoai TheLoai { get; set; }
    }
}