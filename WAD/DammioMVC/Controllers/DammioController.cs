using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DammioMVC.Controllers
{
    public class DammioController : Controller
    {
        // GET: /Dammio/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello(string name,int numTImes=1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTImes = numTImes;
            return View();
        }

        //GET: /Dammio/ChaoMung/
        public string ChaoMung(string ten,int tuoi=1)
        {
            return HttpUtility.HtmlEncode("Xin Chao "+ten+".tuoi cua ban: "+tuoi);
        }
    }
}