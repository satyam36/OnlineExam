using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            
            if (ModelState.IsValid)
                return RedirectToAction("Dashboard", "StudentDashboard");
            return View();
        }
    }
}