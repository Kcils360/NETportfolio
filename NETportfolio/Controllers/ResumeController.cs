using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NETportfolio.Controllers
{
    public class ResumeController : Controller
    {
        public IActionResult Resume()
        {
            return View();
        }
    }
}