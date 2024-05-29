
using Microsoft.AspNetCore.Mvc;

using WebApp2ByNishan.Service;
namespace WebApp2ByNishan.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }
    }

}