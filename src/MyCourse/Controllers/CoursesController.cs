using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCourse.Models.Services.Application;
using MyCourse.Models.ViewModels;

namespace MyCourse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            //posso anche scrivere var courseService = new CourseService();
            CourseService courseService = new CourseService();
            List <CourseViewModel> courses = courseService.GetServices();//vogliamo che l'oggetto courses tramita l'oggetto courseService vada a prendere tutti i corsi disposti in una lista
            return View(courses); //passiamo l'oggetto contenente l'elenco di tutti i corsi alla view che se ne deve occupare
        }
        
        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}