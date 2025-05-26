﻿using GoshehArtWebApp.Data;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GoshehArtWebApp.Models;
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
        public IActionResult Create()
        {
            CreateColorViewModel color = new CreateColorViewModel();
            return View(color);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateColorViewModel colors)
        {
            if (ModelState.IsValid)
            {
                var newColors = new Color
                {
                    Name = colors.Name,
                    StartColor = colors.StartColor,
                    EndColor = colors.EndColor,
                    DarkStartColor = colors.DarkStartColor,
                    DarkEndColor = colors.DarkEndColor
                };

                _context.Colors.Add(newColors);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(colors);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var color = _context.Colors.FirstOrDefault(p => p.Id == id);

            if (color == null)
            {
                return NotFound();
            }

            var viewModel = new CreateColorViewModel
            {
                Id = color.Id,
                Name = color.Name,
                StartColor = color.StartColor,
                EndColor = color.EndColor,
                DarkStartColor = color.DarkStartColor,
                DarkEndColor = color.DarkEndColor
            };

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CreateColorViewModel colors)
        {
            
            if (ModelState.IsValid)
            {
                var updatingColors = await _context.Colors.FirstOrDefaultAsync(c => c.Id == colors.Id);

                if (updatingColors == null)
                {
                    return NotFound();
                }

                updatingColors.Name = colors.Name;
                updatingColors.StartColor = colors.StartColor;
                updatingColors.EndColor = colors.EndColor;
                updatingColors.DarkStartColor = colors.DarkStartColor;
                updatingColors.DarkEndColor = colors.DarkEndColor;

                _context.Colors.Update(updatingColors);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(colors);
        }

        public async Task<IActionResult> Delete(int? id)
        {

            var colors = await _context.Colors.FindAsync(id);
            
            if (id == null || _context.Colors == null)
            {
                return NotFound();
            }

            var cat = await _context.Colors
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cat == null)
            {
                return NotFound();
            }

            return View(colors);

        }

        // POST: Db/Delete/5
        [HttpPost, ActionName("Delete")]
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Colors == null)
            {
                return Problem("Entity set 'ApplicationDbConext.Colors'  is null.");
            }
            var colors = await _context.Colors.FindAsync(id);
            if (colors != null)
            {
                _context.Colors.Remove(colors);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
