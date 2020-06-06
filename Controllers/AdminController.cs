using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data.RegisterRepositry;
using Exmination.Models;
using Exmination.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRegisterRepositry repositry;

        public AdminController(IRegisterRepositry repositry)
        {
            this.repositry = repositry;
        }
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

        public ActionResult<IEnumerable<Registation>> Dashboard()
        {
            IEnumerable<Registation> registations = repositry.GetRegistation();

            return View(registations);
        }
        
        public IActionResult EnrollApprove()
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