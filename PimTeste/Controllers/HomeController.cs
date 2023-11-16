using Microsoft.AspNetCore.Mvc;
using PimTeste.Models;
using System.Diagnostics;

namespace PimTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Principal()
        {
            return View();
        }

       

       

    }
}