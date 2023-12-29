using Microsoft.AspNetCore.Mvc;

namespace epichomes.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
