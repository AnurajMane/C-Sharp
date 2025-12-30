using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using studobjcontrollertoview.Models;

namespace studobjcontrollertoview.Controllers
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

        public IActionResult StudentDetails()
        {
            Student studentobj = new Student();
            studentobj.id = 21;
            studentobj.name = "Anuraj";
            studentobj.email = "anuraj@gmail.com";
            studentobj.phone = "9876543210";
            studentobj.address = "Kolhapur";
            studentobj.marks = 95;


            return View(studentobj);
        }
    }
}
