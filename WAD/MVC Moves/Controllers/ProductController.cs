using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Moves.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public string product(string name,string category,int ID = 1)
        {
            return HttpUtility.HtmlEncode("Name: " + name + " Categoty: " + category + " ID: " + ID);
        }
    }
}