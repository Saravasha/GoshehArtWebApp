using GoshehArtWebApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class ProductionController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductionController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "Production");
            return View(page);
        }
    }
}

