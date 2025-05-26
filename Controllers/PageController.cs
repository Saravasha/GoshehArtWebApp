using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using NuGet.ContentModel;


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

            var pageList = _context.Pages.Include(c => c.Contents).ToList();
            
            return View(pageList);
        }

        // GET: PageController/Details/5
        public IActionResult Details(int id)
        {
            Page? page = _context.Pages
                .Include(c => c.Contents)
                .FirstOrDefault(p => p.Id == id);

            return View(page);
        }

        //GET: PageController/Create
        public IActionResult Create()
        {
            CreatePageViewModel cpvm = new CreatePageViewModel();
            var contents = _context.Contents;

            ViewBag.ContentList = new SelectList(contents, "Id", "Title");

            return View(cpvm);
        }

        [HttpPost]
        public IActionResult Create(CreatePageViewModel page, string containerContent, List<string> Contents)
        {
            

            CreatePageViewModel cpvm = new CreatePageViewModel();
            ModelState.Remove("Id");


            if (ModelState.IsValid)
            {
                var PageToAdd = new Page()
                {
                    Title = page.Title,
                    Container = containerContent
                };

                Content contToAdd = new Content();
                foreach (var item in Contents)
                {
                    int castItem = Int32.Parse(item);
                    contToAdd = _context.Contents.FirstOrDefault(c => c.Id == castItem);

                    if (contToAdd != null)
                    {
                        PageToAdd.Contents.Add(contToAdd);
                    }
                }

                _context.Pages.Add(PageToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (page.Contents.Count == 0)
                {
                    ViewBag.ContentError = "Content is Required";
                }

                var contents = _context.Contents;
                ViewBag.ContentList = new SelectList(contents, "Id", "Title");

                return View(cpvm);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {

            CreatePageViewModel cpvm = new CreatePageViewModel();
            Page? page = _context.Pages
                .Include(c => c.Contents)
                .FirstOrDefault(p => p.Id == id);

            List<int>? contentsId = new();
            foreach (var pageNum in page.Contents)
            {
                contentsId.Add(pageNum.Id);
            }
            if (page != null)
            {
                cpvm.Title = page.Title;
                cpvm.Container = page.Container;
                cpvm.ContentIds = contentsId;

                var contents = _context.Contents;

                ViewBag.ContentList = new MultiSelectList(contents, "Id", "Title");
            }

            return View(cpvm);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CreatePageViewModel page, string title, string container, List<string> ContentIds)
        {
       
            Page? pageToEdit = _context.Pages.Find(id);

            ModelState.Remove("Id");
            ModelState.Remove("Container");

            if (pageToEdit != null && ModelState.IsValid)
            {
                pageToEdit.Title = page.Title;
                pageToEdit.Container = page.Container;

                var contToDelete = _context.Pages.Include(c => c.Contents)
                    .FirstOrDefault(p => p.Id == id);

                List<Content> tempList = new List<Content>();

                foreach (var item in contToDelete.Contents)
                {
                    tempList.Add(item);
                }

                foreach (var cont in tempList)
                {
                    contToDelete.Contents.Remove(cont);
                }

                Content? contToAdd = new Content();
                foreach (var item in ContentIds)
                {
                    int castItem = Int32.Parse(item);
                    contToAdd = _context.Contents.FirstOrDefault(c => c.Id == castItem);

                    if (contToAdd != null)
                    {
                        pageToEdit.Contents.Add(contToAdd);
                    }

                }

                _context.Pages.Update(pageToEdit);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null || _context.Pages == null)
            {
                return NotFound();
            }

            var page = await _context.Pages.Include(c => c.Contents)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST: AssetController/Delete/5

        // POST: Db/Delete/5
        [HttpPost, ActionName("Delete")]
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, IFormCollection collection)
        {
            if (_context.Pages == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Pages' is null.");
            }
            var content = await _context.Pages.FindAsync(id);

            var page = await _context.Pages.OrderBy(e => e.Title).Include(e => e.Contents).FirstAsync();

            foreach (var cont in page.Contents)
            {
                cont.Page = null;
            }

            if (content != null)
            {
                _context.Pages.Remove(content);
            }


            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
