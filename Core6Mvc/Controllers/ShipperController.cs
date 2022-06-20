using Microsoft.AspNetCore.Mvc;
using Northwind.Entities;

namespace Core6Mvc.Controllers
{
    public class ShipperController : Controller
    {
        private readonly NorthwindContext context;

        public ShipperController(NorthwindContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            var result = context.Shippers.ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Shipper shipper = new();
            return View(shipper);
        }

        [HttpPost]
        public IActionResult Create(Shipper shipper)
        {
            if (ModelState.IsValid)
            {
                context.Shippers.Add(shipper);
                context.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(shipper);
        }
    }
}