using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;

namespace Core6Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager productManager;

        public ProductController(IProductManager productManager)
        {
            this.productManager = productManager;
        }
        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View();
        }
    }
}
