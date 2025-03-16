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
    public class ContentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContentController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            var cvm = new ContentViewModel();

            cvm.Contents = _context.Contents.Include(c => c.Page).ToList();

            return View(cvm);
        }

        // GET: PageController/Details/5
        public IActionResult Details(int id)
        {
            Content? content = _context.Contents
                .Include(c => c.Page)
                .FirstOrDefault(p => p.Id == id);

            return View(content);
        }

        //GET: PageController/Create
        public IActionResult Create()
        {
            CreateContentViewModel cvm = new CreateContentViewModel();
            var pages = _context.Pages;

            ViewBag.PageList = new SelectList(pages, "Id", "Title");

            return View(cvm);
        }

        [HttpPost]
        public IActionResult Create(CreateContentViewModel content, List<string> Pages)
        {
            CreateContentViewModel ccvm = new CreateContentViewModel();
            ModelState.Remove("Id");
            if (ModelState.IsValid)
            {
                var ContentToAdd = new Content()
                {
                    Title = content.Title,
                    Body = content.Body
                };

                Page? pageToAdd = new Page();
                foreach (var item in Pages)
                {
                    int castItem = Int32.Parse(item);
                    pageToAdd = _context.Pages.FirstOrDefault(c => c.Id == castItem);

                    if (pageToAdd != null)
                    {
                        ContentToAdd.Pages.Add(pageToAdd);
                    }
                }

                _context.Contents.Add(ContentToAdd);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (content.Pages.Count == 0)
                {
                    ViewBag.PageError = "Page is Required";
                }

                var pages = _context.Pages;
                ViewBag.PageList = new SelectList(pages, "Id", "Title");

                return View(ccvm);
            }
        }


        [HttpGet]
        public IActionResult Edit(int id, string title, string container)
        {

            CreateContentViewModel ccvm = new CreateContentViewModel();
            Content? content = _context.Contents
                .Include(c => c.Page)
                .FirstOrDefault(content => content.PageId == id);


            List<int>? pagesId = new();
            //foreach (var contentNum in content.PageId)
            //{
            //    pagesId.Add(contentNum.Id);
            //}
            if (content != null)
            {
                ccvm.Title = content.Title;
                ccvm.Body = content.Body;
                //ccvm.Container = content.Container;
                ccvm.PageIds = pagesId;

                var pages = _context.Pages;

                ViewBag.ContentList = new MultiSelectList(pages, "Id", "Title");
            }

            if (content == null)
            {
                content = new Content();
                content.Title = title;

                _context.Contents.Add(content);
                _context.SaveChanges();
            }



            return View(ccvm);

            //// SELECT * FROM Pages WHERE Title = {title}
            //var page = _context.Pages.FirstOrDefault(x => x.Title == title);

            //if (page == null)
            //{
            //    page = new Page();
            //    page.Title = title;

            //    _context.Pages.Add(page);
            //    _context.SaveChanges();
            //}

            //return View(page);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CreateContentViewModel content, string title, string container, List<string> PageIds)
        {

            Content? contentToEdit = _context.Contents.Find(id);

            ModelState.Remove("Id");
            ModelState.Remove("Body");

            if (contentToEdit != null && ModelState.IsValid)
            {
                contentToEdit.Title = content.Title;
                contentToEdit.Body = content.Body;

                var pageToDelete = _context.Contents.Include(c => c.PageId)
                    .FirstOrDefault(p => p.PageId == id);

                List<Page> tempList = new List<Page>();

                //foreach (var item in pageToDelete.PageId)
                //{
                //    tempList.Add(item);
                //}

                //foreach (var page in tempList)
                //{
                //    pageToDelete.Pages.Remove(page);
                //}

                Page? pageToAdd = new Page();
                foreach (var item in PageIds)
                {
                    int castItem = Int32.Parse(item);
                    pageToAdd = _context.Pages.FirstOrDefault(c => c.Id == castItem);

                    if (pageToAdd != null)
                    {
                        //contentToEdit.Pages.Add(pageToAdd);
                    }

                }

                _context.Contents.Update(contentToEdit);
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
            var cvm = new ContentViewModel();
            var content = await _context.Contents.FindAsync(id);
            cvm.Title = content.Title;
            cvm.Page = content.Page;
            cvm.Body = content.Body;

            cvm.Contents = _context.Contents.Include(c => c.Pages).ToList();

            if (id == null || _context.Contents == null)
            {
                return NotFound();
            }

            var cont = await _context.Contents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cont == null)
            {
                return NotFound();
            }

            return View(cvm);
        }

        // POST: AssetController/Delete/5

        // POST: Db/Delete/5
        [HttpPost, ActionName("Delete")]
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, IFormCollection collection)
        {
            if (_context.Contents == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Contents' is null.");
            }
            var page = await _context.Contents.FindAsync(id);
            if (page != null)
            {
                _context.Contents.Remove(page);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}



//var page = _context.Pages.FirstOrDefault(x => x.Title == title);

//if (page == null)
//{
//    return View("Error");
//}

//page.Container = header;
//_context.SaveChanges();

//return RedirectToAction(nameof(Index));