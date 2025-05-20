using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class ColorController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ColorController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var colors = _context.Colors.ToList();

            return View(colors);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            var colors = _context.Colors.FirstOrDefault(p => p.Id == id);
            
            return View(colors);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Color colors)
        {
            
            if (ModelState.IsValid)
            {
                var success =  _context.Colors.Update(colors);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Problem("Something went wrong.");
            }
        }

    }
}
