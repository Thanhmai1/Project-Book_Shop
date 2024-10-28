using Microsoft.AspNetCore.Mvc;

namespace Project_Book_Shop.Controllers
{
	[Route("product-single")]
	public class Product_Single : Controller
	{
		[HttpGet("")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
