using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using W02s2.Models;

namespace W02s2
{
    public partial class Site_Mobile : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }
    }
}