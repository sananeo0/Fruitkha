﻿using Microsoft.AspNetCore.Mvc;

namespace Fruitkha.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Contact()
		{
			return View();
		}
	}
}
