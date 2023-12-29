using Microsoft.AspNetCore.Mvc;

namespace epichomes.Controllers
{
    public class RestaurantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
