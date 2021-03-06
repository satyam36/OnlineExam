﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data.RegisterRepositry;
using Exmination.Models;
using Exmination.Models.Account;
using Exmination.Models.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IRegisterRepositry _repositry;

        public AccountController(IHostingEnvironment hostingEnvironment, IRegisterRepositry repositry)
        {
            this.hostingEnvironment = hostingEnvironment;
            _repositry = repositry;
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
            {
                HttpContext.Session.SetString("SessionName", "Jarvik");
                HttpContext.Session.SetInt32("SessionAge", 24);
                return RedirectToAction( "index", "Home");
            }
                //return RedirectToAction("Dashboard", "StudentDashboard");
            return View();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Registration(RegistrationViewModel model)
        {

            if(ModelState.IsValid)
            {
                string password = model.CandidateName.Substring(0, 4).ToUpper() + model.Mobile.Substring(0, 4);
                Console.WriteLine(password);
                Registation registation = new Registation()
                {
                    CandidateName = model.CandidateName,
                    Email = model.Email,
                    Mobile = model.Mobile,
                    ExaminationApplied = model.ExaminationApplied,
                    Password = password
                };

                _repositry.Add(registation);
            }
            return View();
        }

        public IEnumerable<Registation> GetRegistration()
        {
            return _repositry.GetRegistation();
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
