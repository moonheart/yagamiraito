using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using yagamiraito.Dal;

namespace yagamiraito.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new YagamiDbContext())
            {
                return View(db.Products.ToList());
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
