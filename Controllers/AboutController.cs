using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var page = _context.Pages.FirstOrDefault(x => x.Title == "About");
            return View(page);
        }
    }
}
