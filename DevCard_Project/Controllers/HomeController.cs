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
        //public JsonResult Contact(IFormCollection model)
        //{
        //    var name = model["name"];
        //    var email = model["email"];
        //    var service = model["service"];
        //    var message = model["message"];
        //    return Json(Ok());
        //}


        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات بدرستی وارد نشده مجددا تلاش فرمایید";
                return View(model);
            }

            ViewBag.success = "اطلاعات بدرسی ارسال شد با تشکر";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}