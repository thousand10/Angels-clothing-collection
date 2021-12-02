using angels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace angels.Controllers
{
    public class WebApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Contact()
        {
            return View();
        }


        public IActionResult About()
        {
            return View();
        }
    }
}
