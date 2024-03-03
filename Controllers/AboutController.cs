using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public AboutController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "About");
            return View(page);
        }
    }
}
