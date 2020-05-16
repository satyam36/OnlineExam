using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string x)
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCenter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCenter(EximinationCenter model)
        {
            return View();
        }
    }
}