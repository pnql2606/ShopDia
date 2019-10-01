using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopDia.Models;
using System.Web.ModelBinding;

namespace ShopDia
{
    public partial class ChiTiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Album> GetDetails([QueryString("AlbumID")] int? albumID)
        {
            var _db = new ShopDia.Models.AlbumContext();
            IQueryable<Album> query = _db.Albums;
            if (albumID.HasValue && albumID > 0)
            {
                query = query.Where(p => p.MaDia == albumID);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}