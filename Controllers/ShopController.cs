using Fruitkha.Data;
using Fruitkha.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class ShopController : Controller
	{
		public IActionResult Shop()
		{
			List<Product> products = ProductRepository.GetProducts();
			return View(products);
		}

		public IActionResult SingleProduct()
		{
			return View();
		}
	}
}
