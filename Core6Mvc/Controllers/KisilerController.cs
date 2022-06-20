using Core6Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core6Mvc.Controllers
{
    public class KisilerController : Controller
    {
        public IActionResult Index()
        {

            List<Kisi> kisiler = new List<Kisi>
            {
                new Kisi {Ad="Ali",Soyad="Kaya",Gsm="532" },
                new Kisi {Ad="Ayse",Soyad="Yilmaz",Gsm="532" },
                new Kisi {Ad="Veli",Soyad="Gezer",Gsm="532" },
                new Kisi {Ad="Fatma",Soyad="Kaya",Gsm="532" },

            };
            return View(kisiler);
        }
    }
}