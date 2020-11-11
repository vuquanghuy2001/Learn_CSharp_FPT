using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Moves.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //GET: HelloWorld
        //public string Index()
        //{
        //    return "CheckerViet";
        //}

        //GET: HelloWorld/Welcome
        //public string welcome()
        //{
        //    return "hihihihiii ranh cao thu";
        //}

        //public string welcome(string name,int ID = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + " ID: " + ID);
        //}

        public ActionResult Welcome(string name,int numtimes=1)
        {
            ViewBag.Message = "Hello " + name + " " + numtimes;
            ViewBag.numtimes = numtimes;
            return View();
        }
    }
}