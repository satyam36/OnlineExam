using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult StudentDashboard()
        {
            return View();
        }
        public IActionResult Admission()
        {
            return View();
        }
    }
}