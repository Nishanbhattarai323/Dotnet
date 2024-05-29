// SessionController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApp6ByNishan.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("uname", "Nishan");
            HttpContext.Session.SetString("pw", "12345");
            return View();
        }

        public IActionResult SessionPage()
        {
            string uname = HttpContext.Session.GetString("uname");
            string pw = HttpContext.Session.GetString("pw");
            ViewBag.username = uname;
            ViewBag.password = pw;
            return View();
        }
    }
}
