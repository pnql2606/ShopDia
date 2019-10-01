using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ShopDia.Models
{
    public class DuLieuAlbum : DropCreateDatabaseAlways<AlbumContext>
    {
        protected override void Seed(AlbumContext context)
        {
            GetTheLoais().ForEach(c => context.TheLoais.Add(c));
            GetAlbums().ForEach(p => context.Albums.Add(p));
        }
        private static List<TheLoai> GetTheLoais()
        {
            var categories = new List<TheLoai> {
                new TheLoai
               {
                 MaTL = 1,
                 TenTL = "Nhạc Việt"
                 },
                 new TheLoai
                 {
                 MaTL = 2,
                 TenTL = "Nhạc Hàn"
                 },
                 new TheLoai{
                 MaTL= 3,
                 TenTL = "Nhạc Âu - Mĩ"
                 },
                 };
            return categories;
        }
        private static List<Album> GetAlbums()
        {
            var albums = new List<Album> {

                 new Album
                 {
                 MaDia = 1,
                 TenDia = "Thám tử Conan",
                 MoTa = "Kudo Shinichi bị một tổ chức áo đen cho uống thuốc độc và teo nhỏ trở thành Edogawa Conan." +
                 " Mặc dù cơ thể bị teo nhỏ nhưng với trí tuệ của một thám tử lừng danh anh vẫn phá được nhiều vụ án mà người lớn phải đau đầu suy nghĩ",
                 HinhAnh="Pic1.JPG",
                 Gia = 10000,
                 MaTL = 1
                 },

                 new Album
                 {
                 MaDia = 2,
                 TenDia = "7 viên ngọc rồng",
                 MoTa = "Songoku cùng các chiến binh Z phải chiến đấu với nhiều quái vật và mọi người cùng nhau tăng cấp lên các sức mạnh mới",
                 HinhAnh="Pic2.JPG",
                 Gia = 12000,
                 MaTL = 2
                 },

                 new Album
                 {
                 MaDia = 3,
                 TenDia = "One Punch Man",
                 MoTa = "Saitama cùng đồng bọn đánh với các quái vât. Riêng anh chỉ với 1 đấm có thể giết hết quái vật",
                 HinhAnh="Pic3.JPG",
                 Gia = 10000,
                 MaTL = 3
                 },
                 new Album
                 {
                 MaDia = 4,
                 TenDia = " Ore no Yome ni Nare Yo",
                 MoTa = "Bộ truyện lãng mạn học đường cùng với Yome và Ore",
                 HinhAnh="Pic4.jpg",
                 Gia = 10000,
                 MaTL = 4
                 },

                 };
            return albums;
        }
    }
}