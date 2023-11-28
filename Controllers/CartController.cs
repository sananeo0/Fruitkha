using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class CartController : Controller
	{
		public IActionResult Cart()
		{
			return View();
		}
	}
}
