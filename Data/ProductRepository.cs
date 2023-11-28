using Fruitkha.Entities;
namespace Fruitkha.Data
{
	public static class ProductRepository
	{
		public static List<Product> GetProducts()
		{
			return new()
			{
				new()
				{
					Name="Strawberry",
					Price=75,
					ImgName="product-img-1.jpg"
				},
				new()
				{
					Name="Berry",
					Price=85,
					ImgName="product-img-2.jpg"
				},
				new()
				{
					Name="Lemon",
					Price=68,
					ImgName="product-img-3.jpg"
				},
				new()
				{
					Name="Avocado",
					Price=68,
					ImgName="product-img-4.jpg"
				},
				new()
				{
					Name="Green Apple",
					Price=68,
					ImgName="product-img-5.jpg"
				},
				new()
				{
					Name="Strawberry",
					Price=68,
					ImgName="product-img-6.jpg"
				}
			};


		}
	}
}
