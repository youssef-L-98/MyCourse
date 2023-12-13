using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return Content("sono index");
        }
        
        public IActionResult Detail(string id)
        {
            return Content($"sono Detail, ho ricevuto l'id {id}");
        }
    }
}