using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoshehArtWebApp.Controllers
{
    public class ContentController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ContentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var pvm = new ContentViewModel();

            pvm.Contents = _context.Contents.Include(p => p.Page).ToList();

            return View(pvm);
        }
    }
}
