using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GoshehArtWebApp.Controllers
{
    public class ContentController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly ContentViewModel cvm = new();
        private readonly CreateContentViewModel ccvm = new();
        public ContentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cvm = new ContentViewModel();
            
            cvm.Contents = _context.Contents.Include(p => p.Page).ToList();

            return View(cvm);
        }

        // GET: ContentController/Details/5
        public IActionResult Details(int id)
        {
            Content? content = _context.Contents
                .Include(p => p.Page)
                .FirstOrDefault(p => p.Id == id);

            return View(content);
        }

        //GET: ContentController/Create
        public IActionResult Create()
        {
            CreateContentViewModel cvm = new CreateContentViewModel();
            var pages = _context.Pages;


            ViewBag.PageList = new SelectList(pages, "Id", "Title");
            return View(cvm);
        }

        [HttpPost]
        public IActionResult Create(CreateContentViewModel cont)
        {
            
            if (ModelState.IsValid)
            {
                var ContentToAdd = new Content()
                {
                    Title = cont.NewContent.Title,
                    Body = cont.NewContent.Body,
                    PageId = cont.NewContent.PageId
                };


                _context.Contents.Add(ContentToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (cont.Pages.Count == 0)
                {
                    ViewBag.ContentError = "Page is Required";
                }

                var pages = _context.Contents;
                ViewBag.PageList = new SelectList(pages, "Id", "Title");

                return View(ccvm);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contents == null)
            {
                return NotFound();
            }

            var content = await _context.Contents.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }
            return View(content);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ContentViewModel cont)
        {
            //var contentToEdit = _context.Contents.Find(id);

            if (id != cont.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //contentToEdit.Title = cont.Title;

                _context.Update(cont);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(cont);
            }
        }
        public async Task<IActionResult> Delete(int? id)
        {

            Content? content = await _context.Contents
                .Include(p => p.Page)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (id == null || _context.Contents == null)
            {
                return NotFound();
            }

            //var content = await _context.Contents
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contents == null)
            {
                return Problem("Entity Set 'ApplicationDbContext.Content' is null.");
            }

            var cont = await _context.Contents.FindAsync(id);
            if (cont != null)
            {
                _context.Contents.Remove(cont);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
