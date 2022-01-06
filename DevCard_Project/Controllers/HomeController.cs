using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dev.Models;
using DevCard_Project.Models;

namespace Dev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        //[HttpPost]
        //public JsonResult Contact(IFormCollection form)
        //{
        //    var name = form["name"];
        //    var email = form["email"];
        //    var service = form["service"];
        //    var message = form["message"];
        //    return Json(Ok());
        //}


        [HttpPost]
        public JsonResult Contact(Contact form)
        {
            return Json(Ok());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}