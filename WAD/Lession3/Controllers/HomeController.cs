using Lession3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lession3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
