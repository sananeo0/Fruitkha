using Microsoft.AspNetCore.Mvc;
namespace Fruitkha.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult About()
		{
			return View();
		}
	}
}
