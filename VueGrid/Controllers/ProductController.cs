using Microsoft.AspNetCore.Mvc;
using VueGrid.Models;

namespace VueGrid.Controllers
{
    public class ProductController : Controller
    {
        [HttpPost]
        public IActionResult Productlist(GridCommand command, ProductListModel model)
        {
            List<ProductViewModel> products = new List<ProductViewModel>();
            products.Add(new ProductViewModel() { Id = 1, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 2, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 3, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 4, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 5, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 6, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 7, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 8, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 9, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 10, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 11, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 12, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 13, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 14, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 15, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 16, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 17, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 18, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 19, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 20, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 21, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 22, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 23, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 24, Code = "A1A", Name = "ASUS TUF GAMING A17", Price = 40000 });
            products.Add(new ProductViewModel() { Id = 25, Code = "A15", Name = "ASUS TUF GAMING A15", Price = 31000 });
            products.Add(new ProductViewModel() { Id = 26, Code = "A19", Name = "ASUS TUF GAMING ", Price = 1 });
            products.Add(new ProductViewModel() { Id = 27, Code = "A20", Name = "ASUS TUF GAMING ", Price = 2 });
            products.Add(new ProductViewModel() { Id = 28, Code = "A21", Name = "ASUS TUF GAMING ", Price = 3 });
            products.Add(new ProductViewModel() { Id = 29, Code = "A22", Name = "ASUS TUF GAMING ", Price = 4 });
            products.Add(new ProductViewModel() { Id = 30, Code = "A23", Name = "ASUS TUF GAMING ", Price = 5 });

            return Json(new GridModel<ProductViewModel>
            {
                rows = products.Where(m => m.Name.Contains(model.SearchProductName)).Skip((command.Page * command.PageSize) - command.PageSize).Take(command.PageSize),
                total = products.Count,
            });
        }
    }
}
