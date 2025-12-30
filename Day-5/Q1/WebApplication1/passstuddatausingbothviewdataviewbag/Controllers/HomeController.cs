using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using passstuddatausingbothviewdataviewbag.Models;

namespace passstuddatausingbothviewdataviewbag.Controllers
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

        public IActionResult StudentData()
        {
            //Using ViewData
            ViewData["name"]= "John Doe";
            ViewData["age"]= 21;

            //Using ViewBag
            ViewBag.city = "Kolhapur";
            ViewBag.country = "India";

            return View();
        }
    }
}
