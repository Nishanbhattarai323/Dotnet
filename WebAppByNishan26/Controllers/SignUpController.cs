using Microsoft.AspNetCore.Mvc;
using WebAppByNishan26.Models;

namespace WebAppByNishan26.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new SignUpViewModel();
            viewModel.Name = "Your Name";
            viewModel.RollNo = "Your RollNo";
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Process form submission
                // Redirect or perform other actions
            }
            return View(model);
        }
    }
}