using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
          return Content("sono la Index della Home");

        }
        
    }
}