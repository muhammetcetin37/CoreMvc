using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;
using Northwind.Entities;

namespace Core6Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager manager;
        private readonly IMapper mapper;

        public ProductController(IProductManager manager, IMapper mapper)
        {
            this.manager = manager;
            this.mapper = mapper;

        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View(manager.GetAll().ToList());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = manager.Find(id);

            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            Product product = new Product();
            return View(product);
        }

        // POST: ProductController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(ProductCreateDto createDto)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(createDto);
        //    }
        //    else
        //    {
        //        var result = mapper.Map<Product>(createDto);

        //        manager.Add(result);
        //        return RedirectToAction("Index");
        //    }

        //}

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}