using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Interface
        public IActionResult About()
        {
            // O ViewData é um dicionário do C#
            ViewData["Message"] = "Sales Web MVC App from C# Course";
            ViewData["Author"] = "Renata Cavalheiro";
            // exemplo:
            // ViewData["email"] = "nelio@gmail.com";

            // method builder
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
