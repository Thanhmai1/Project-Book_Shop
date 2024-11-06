using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace Project_Book_Shop.Controllers
{
	[Route("product-single")]
	public class Product_Single : Controller
	{
        private readonly BookShopDbContext _context;
        public Product_Single(BookShopDbContext context)
        {
            _context = context;
        }
        [HttpGet("")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
