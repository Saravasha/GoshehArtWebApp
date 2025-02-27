using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class ReactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
