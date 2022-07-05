using Core6Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Core6Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sliders = new List<SliderVM>();
            sliders.Add(new SliderVM { Name = "Google", Url = "https://www.google.com" });
            sliders.Add(new SliderVM { Name = "Microsoft", Url = "https://www.Microsoft.com" });
            sliders.Add(new SliderVM { Name = "amazon", Url = "https://www.amazon.com" });

            return View(sliders);

        }

        public IActionResult Privacy()
        {
            var sliders = new List<SliderVM>();
            sliders.Add(new SliderVM { Name = "Google", Url = "https://www.google.com" });
            sliders.Add(new SliderVM { Name = "Microsoft", Url = "https://www.Microsoft.com" });
            sliders.Add(new SliderVM { Name = "amazon", Url = "https://www.amazon.com" });

            return View(sliders);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}