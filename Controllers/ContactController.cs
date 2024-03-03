using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "Contact");
            return View(page);
        }
    }
}