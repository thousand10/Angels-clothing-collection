using angels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using angels.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;


namespace angels.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        public DashboardController(ApplicationDbContext db)
        {
            _db = db;
        }


        [Authorize]
        public IActionResult Board()
        {
            IEnumerable<Product> products = _db.products;
            return View(products);
        }


        [Authorize]
        public IActionResult Add()
        {
            return View();
        }


        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Add(Product data)
        {
            if (ModelState.IsValid)
            { 
                _db.products.Add(data);
                _db.SaveChanges();
                return RedirectToAction("Board");
            }
            return View(data);
        }



        [Authorize]
        public IActionResult Update(int? id)
        {
            if (id == null && id == 0)
            {
                return NotFound();
            }
            var productId = _db.products.Find(id);
            if (productId == null)
            {
                return NotFound();
            }
            return View(productId);
        }


        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Update(Product data)
        {
  
                if (ModelState.IsValid)
                {
                    _db.products.Update(data);
                    _db.SaveChanges();
                    return RedirectToAction("Board");
                }
                return View(data);
        }


        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id != null && id == 0)
            {
                return NotFound();
            }

            var productid = _db.products.Find(id);  
            if (productid == null)
            {
                return NotFound();
            }
            return View(productid);
        }


        [Authorize]
        [HttpPost]
        public IActionResult DeleteFinal(int? ids)
        {
            var userid = _db.products.Find(ids);
            if (userid == null)
            {
                return View("Delete");
            }
            _db.products.Remove(userid);
            _db.SaveChanges();
            return RedirectToAction("Board");

        }


        [Authorize]
        public IActionResult ProductDetail(int? id)
        {
            if (id == null && id == 0)
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
