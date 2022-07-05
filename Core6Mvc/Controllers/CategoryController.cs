using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Northwind.BL.Abstract;

namespace Core6Mvc.Controllers
{

    public class CategoryController : Controller
    {
        private readonly ICategoryManager categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            var result = categoryManager.GetAll();
            return View(result);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

    }
}