using Microsoft.AspNetCore.Mvc;
using PRELIM_E3_Assignment_FugenAira_BSIT_32E1.Models;
using System.Diagnostics;

namespace PRELIM_E3_Assignment_FugenAira_BSIT_32E1.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public SchoolController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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
