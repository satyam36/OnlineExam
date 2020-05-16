using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Exmination.Controllers
{
    public class PortalController : Controller
    {
        public IActionResult Instruction()
        {
            return View();
        }

        public IActionResult Questions()
        {
            return View();
        }
        public IActionResult Question()
        {
            return View();
        }

        public IActionResult Pannel()
        {
            return View();
        }
    }
}