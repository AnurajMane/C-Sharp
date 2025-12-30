using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using passlistofsubjects.Models;

namespace passlistofsubjects.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<string> subjects = new List<string>
            {
                "Mathematics",
                "Physics",
                "Chemistry",
                "Biology",
                "History",
                "Geography",
                "English Literature",
                "Computer Science"
            };

            ViewData["SubjectsList"] = subjects;

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
}
