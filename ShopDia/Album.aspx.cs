using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel.DataAnnotations;
using ShopDia.Models;
using System.Web.ModelBinding;

namespace ShopDia
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Album> GetAlbums([QueryString("id")] int? categoryId)
        {
            var _db = new ShopDia.Models.AlbumContext();
            IQueryable<Album> query = _db.Albums;
            if (categoryId.HasValue && categoryId > 0)
            {
                query = query.Where(p => p.MaTL == categoryId);
            }
            return query;
        }
    }
}