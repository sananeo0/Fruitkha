using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class _404Controller : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
