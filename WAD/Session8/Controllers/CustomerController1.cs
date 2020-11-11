using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Session8.Models;

namespace Session8.Controllers
{
    public class CustomerController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(
            [Bind("Name,Emailid")] CustomerModel customerModel
            )
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(customerModel);
        }
    }
}
