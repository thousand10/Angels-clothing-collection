using angels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using angels.Data;


namespace angels.Controllers
{
    public class StoreController : Controller
    {

        private readonly ApplicationDbContext _db;
        public StoreController(ApplicationDbContext db)
        {
            _db = db;
        }


        [Authorize]
        public IActionResult Stores()
        {
            IEnumerable<Product> products = _db.products;
            return View(products);
        }



        public IActionResult ProductDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
