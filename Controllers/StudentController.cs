using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Exmination.Data;
using Exmination.Models.Student;
using Exmination.ModelView.Student;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Exmination.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHostingEnvironment hostingEnvironment;
        public StudentController(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Enroll()
        {
            CenterData centerData = new CenterData();
            EnrollmentViewModel enrollment = new EnrollmentViewModel();
            enrollment.ExameCenterCh1 = centerData.Center();
            enrollment.ExameCenterCh2 = centerData.Center();
            enrollment.ExameCenterCh3 = centerData.Center();
            return View(enrollment);
        }
        [HttpPost]
        public IActionResult Enroll(EnrollmentViewModel model)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                CenterData centerData = new CenterData();
                EnrollmentViewModel enrollment = new EnrollmentViewModel();
                enrollment.ExameCenterCh1 = centerData.Center();
                enrollment.ExameCenterCh2 = centerData.Center();
                enrollment.ExameCenterCh3 = centerData.Center();
                return View(enrollment);
            }
            //string uniqueFileName = null;
            //string path = model.Profile.FileName;
            //string path2 = model.Signature.FileName;

            //double ImageInKB = model.Profile.Length / 1024;

            //string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "images");
            //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Profile.FileName;
            //string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            //model.Profile.CopyTo(new FileStream(filePath, FileMode.Create));

            return View();
        }

        public IActionResult Admit_Card()
        {
            return View();
            //return new ViewAsPdf();
        }
        [HttpPost]
        public IActionResult Admit_Card(AdmitCard model)
        {
            return RedirectToAction("PrintAdmitCard", "Student");
        }

        public IActionResult PrintAdmitCard()
        {
            return new   ViewAsPdf();
            //return View();
        }

    }
}