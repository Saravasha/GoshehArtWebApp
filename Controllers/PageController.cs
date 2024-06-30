using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class PageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PageController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditPage(string title)
        {
            // SELECT * FROM Pages WHERE Title = {title}
            var page = _context.Pages.FirstOrDefault(x => x.Title == title);

            if (page == null)
            {
                page = new Page();
                page.Title = title;

                _context.Pages.Add(page);
                _context.SaveChanges();
            }

            return View(page);
        }

        [HttpPost]
        public IActionResult SavePage(string title, string content)
        {
            var page = _context.Pages.FirstOrDefault(x => x.Title == title);

            if (page == null)
            {
                return View("Error");
            }

            page.Content = content;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}

