using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Fruitkha.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}