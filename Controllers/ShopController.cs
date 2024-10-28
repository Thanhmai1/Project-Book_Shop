using Microsoft.AspNetCore.Mvc;

namespace Project_Book_Shop.Controllers
{
    [Route("shop")]
    public class ShopController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
