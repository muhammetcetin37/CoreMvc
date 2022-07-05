using AutoMapper;
using Core6Mvc.Models.DTO.Product;
using Core6Mvc.Models.DTO.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Northwind.BL.Abstract;
using Northwind.Entities;

namespace Core6Mvc.Controllers
{
    public class MyProductController : Controller
    {
        private readonly IProductManager productManager;
        private readonly IMapper mapper;
        private readonly ICategoryManager categoryManager;
        private readonly ISupplierManager supplierManager;

        public MyProductController(IProductManager productManager,
                                    IMapper mapper,
                                    ICategoryManager categoryManager,
                                    ISupplierManager supplierManager)
        {
            this.productManager = productManager;
            this.mapper = mapper;
            this.categoryManager = categoryManager;
            this.supplierManager = supplierManager;
        }
        public IActionResult Index()
        {
            var result = productManager.GetInclude(p => p.ProductId > 0,
                p => p.Category,
                p => p.Supplier).ToList();



            ICollection<ProductListDTO> products = mapper.Map<ICollection<ProductListDTO>>(result);
            return View(products);
        }

        [HttpGet]

        public IActionResult Create()
        {
            ProductCreateDTO createDTO = new ProductCreateDTO();
            ViewData["CategoryId"] = new SelectList(categoryManager.GetAll(), "CategoryId", "CategoryName");
            ViewData["SupplierId"] = new SelectList(supplierManager.GetAll(), "SupplierId", "CompanyName");
            return View(createDTO);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Create(ProductCreateDTO input)
        {
            var product = mapper.Map<Product>(input);
            try
            {
                productManager.Add(product);
                return RedirectToAction("Index", "MyProduct");
            }
            catch (Exception ex)
            {

                ModelState.AddModelError("", ex.Message);
            }
            ViewData["CategoryId"] = new SelectList(categoryManager.GetAll(), "CategoryId", "CategoryName");
            ViewData["SupplierId"] = new SelectList(supplierManager.GetAll(), "SupplierId", "CompanyName");
            return View(input);
        }


        public IActionResult OrderDetail(int id)
        {

            var result = productManager.GetInclude(p => p.ProductId == id, p => p.OrderDetails.ToList());


            return View(result);
        }
    }
}