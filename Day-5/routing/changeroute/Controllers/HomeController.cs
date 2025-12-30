using System.Diagnostics;
using changeroute.Models;
using Microsoft.AspNetCore.Mvc;

namespace changeroute.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }



    //https://localhost:7047/student/details/1
    public class StudentController : Controller
    {
        [Route("student/details/{id}")]
        public IActionResult Details(int id)
        {

            ViewBag.studentid = id;
            return View();
        }
    }
}
