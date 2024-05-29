using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApp1ByNishan.Models;


namespace WebApp1ByNishan.Controllers
{
    public class StudentController : Controller
    {
        Student s = new Student()
        {
            StdID = 12,
            Name = "John Doe",
            Address = "123 Main St",
            Faculty = "Computer Science"
        };
        public IActionResult MyRazorPage()
        {
            return View(s);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
                return View("Details", s);
            else
                return View(s);
        }

        public IActionResult Details()
        {
            return View(s);
        }
    }
}