using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GoshehArtWebApp.Controllers
{
   
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "Home");
            return View(page);
        }

        public IActionResult Privacy()
        {
            var page = _dbContext.Pages.FirstOrDefault(x => x.Title == "Privacy");
            return View(page);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}