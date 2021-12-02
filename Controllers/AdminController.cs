using angels.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using angels.Controllers;

namespace angels.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager   <IdentityUser> _userManager;
        private readonly SignInManager  <IdentityUser> _signInManager;
        public AdminController(UserManager<IdentityUser> userManager, SignInManager <IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (username != null && password != null)
            {
                var user = await _userManager.FindByNameAsync(username);
                if(user != null)
                {
                    var LogInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    if(LogInResult.Succeeded)
                    {
                        return RedirectToAction("Board", "Dashboard");
                    }
                }
                return View(user);
            }
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Dashboard");
        }



        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult>  Register(string username, string password)
        {
            if (username != null && password != null)
            {
                var user = new IdentityUser
                {
                    UserName = username,
                };
                var result = await _userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    var SignInResult = await _signInManager.PasswordSignInAsync(user, password, false, false);
                    if (SignInResult.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }

                }
                Console.WriteLine("error");
            }
            return View();

        }
    }
}
