using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class PageController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public PageController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditPage(string title)
        {
            // SELECT * FROM Pages WHERE Title = {title}
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == title);

            if (page == null)
            {
                page = new Page();
                page.Title = title;

                _dbContext.Pages.Add(page);
                _dbContext.SaveChanges();
            }

            return View(page);
        }

        [HttpPost]
        public IActionResult SavePage(string title, string content)
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == title);

            if (page == null)
            {
                return View("Error");
            }

            page.Content = content;
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

