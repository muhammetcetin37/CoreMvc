using AutoMapper;
using Core6Mvc.Models.DTO.Products;
using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;

namespace Core6Mvc.Controllers
{
    public class MyProductController : Controller
    {
        private readonly IProductManager productManager;
        private readonly IMapper mapper;

        public MyProductController(IProductManager productManager, IMapper mapper)
        {
            this.productManager = productManager;
            this.mapper = mapper;
        }
        public IActionResult Index()
        {
            var result = productManager.GetAllInclude(p => p.ProductId > 0,
                p => p.Category,
                p => p.Supplier).ToList();



            ICollection<ProductListDTO> products = mapper.Map<ICollection<ProductListDTO>>(result);
            return View(products);
        }
    }
}