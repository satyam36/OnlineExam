using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public AccountController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

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
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registration(Registration model)
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Registration(Photo model)
        //{
        //    //string uniqueFileName = null;
        //    //string path = model.PhotoPath.FileName;

        //    //double ImageInKB = model.PhotoPath.Length / 1024; 

        //    //string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
        //    //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
        //    //string filePath = Path.Combine(uploadsFolder, uniqueFileName);
        //    //model.PhotoPath.CopyTo(new FileStream(filePath, FileMode.Create));
        //    return View();
        //}
    }
}
