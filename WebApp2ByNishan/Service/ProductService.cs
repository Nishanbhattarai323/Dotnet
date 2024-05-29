
using WebApp2ByNishan.Models;
using WebApp2ByNishan.Service;
namespace WebApp2ByNishan.Services
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
{
new ProductViewModel {Id = 1, Name = "SmartPhone" },
new ProductViewModel {Id = 2, Name = "Headphone" },
new ProductViewModel {Id = 3, Name = "Iphone" },
new ProductViewModel {Id = 4, Name = "Ipad" },
new ProductViewModel {Id = 5, Name = "Laptop" } ,
};
        }
    }
}