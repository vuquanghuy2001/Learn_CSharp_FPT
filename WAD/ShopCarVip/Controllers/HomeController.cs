using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopCarVip.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCarVip.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
