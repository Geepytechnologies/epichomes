using Microsoft.AspNetCore.Mvc;

namespace epichomes.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
