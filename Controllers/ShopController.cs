using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Shop()
		{
			return View();
		}

		public IActionResult SingleProduct()
		{
			return View();
		}
	}
}
