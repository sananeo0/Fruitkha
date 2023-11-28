using Fruitkha.Data;
using Fruitkha.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fruitkha.Models
{
	public class IndexModel : PageModel
	{
		public List<Product> Products { get; set; }

		public void OnGet()
		{
			Products = ProductRepository.GetProducts();
		}
	}
}
