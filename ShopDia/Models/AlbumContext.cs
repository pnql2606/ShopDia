using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ShopDia.Models 
{
    public class AlbumContext : DbContext
    {
        public AlbumContext() : base("ShopDia")
        { }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}