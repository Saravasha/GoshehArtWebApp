using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using System.Collections.Generic;
using System.IO;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class AssetController : Controller
    {
		public string UploadedFile(CreateAssetViewModel asset)
		{
			string? uniqueFileName = null;

			if (asset.ImageUp != null)
			{

                string path = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
				uniqueFileName = Guid.NewGuid().ToString() + "_" + asset.ImageUp.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Copy(filePath, "~/Uploads");
                }
                using (var fileStream = new FileStream(filePath, FileMode.Create))
				{
					asset.ImageUp.CopyTo(fileStream);
				}
			}

			return "/Uploads/" + uniqueFileName; ;
		}

        private readonly ApplicationDbContext _context;
		private readonly IWebHostEnvironment webHostEnvironment;

		public AssetController(ApplicationDbContext context, IWebHostEnvironment webHost)
		{
			_context = context;
			webHostEnvironment = webHost;
		}
		// GET: AssetController

		public IActionResult Index()
		{
			var avm = new AssetViewModel();

			avm.Assets = _context.Assets
				.Include(c => c.Categories).ToList();

			return View(avm);
		}

		// GET: AssetController/Details/5
		public IActionResult Details(int id)
		{
            Asset? asset = _context.Assets
				.Include(c => c.Categories)
				.FirstOrDefault(p => p.Id == id);

			return View(asset);
		}

		// GET: AssetController/Create
		public IActionResult Create()
		{
			CreateAssetViewModel avm = new CreateAssetViewModel();
			var categories = _context.Categories;

			ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

			return View(avm);
		}

        // POST: AssetController/Create
        //[ValidateAntiForgeryToken]
        [HttpPost]
		public IActionResult Create(CreateAssetViewModel asset, List<string> Categories)
		{
			CreateAssetViewModel cavm = new CreateAssetViewModel();

			string uniqueFileName = UploadedFile(asset);
			asset.ImageUrl = uniqueFileName;

			ModelState.Remove("Id");
			//ModelState.Remove("ImageUrl");
			if (ModelState.IsValid)
			{
				var AssetToAdd = new Asset()
				{
					Name = asset.Name,
					Description = asset.Description,
					Author = asset.Author,
					ImageUrl = uniqueFileName
				};

				Category? catToAdd = new Category();
				foreach (var item in Categories)
				{
					int castItem = Int32.Parse(item);
					catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);

					if (catToAdd != null)
					{
						AssetToAdd.Categories.Add(catToAdd);
					}

				}

				_context.Assets.Add(AssetToAdd);
				_context.SaveChanges();

				return RedirectToAction(nameof(Index));
			}
			else
			{
				if (asset.Categories.Count == 0)
				{
					ViewBag.CategoryError = "Category is Required";
				}

				var categories = _context.Categories;
				ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

				return View(cavm);
			}
		}

        // GET: AssetController/Edit/5
        [HttpGet]
		public IActionResult Edit(int id)
		{
			CreateAssetViewModel cavm = new CreateAssetViewModel();
			Asset? asset = _context.Assets
				.Include(c => c.Categories)
				.FirstOrDefault(p => p.Id == id);

			List<int>? categoriesIds = new();
			foreach (var assetNum in asset.Categories)
			{
				categoriesIds.Add(assetNum.Id);
			}

			if (asset != null)
			{
				cavm.Name = asset.Name;
				cavm.Description = asset.Description;
				//cavm.ImageUrl = asset.ImageUrl;
				cavm.Author = asset.Author;
				cavm.CategoryIds = categoriesIds;

				var categories = _context.Categories;

				ViewBag.CategoryList = new MultiSelectList(categories, "Id", "Name");
				ViewBag.Image = asset.ImageUrl;
			}



			return View(cavm);
		}

		// POST: AssetController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(int id, CreateAssetViewModel asset, List<string> CategoryIds)
		{
			Asset? assetToEdit = _context.Assets.Find(id);


			ModelState.Remove("Id");
			ModelState.Remove("ImageUrl");
			ModelState.Remove("ImageUp");
			if (assetToEdit != null && ModelState.IsValid)
			{
				assetToEdit.Name = asset.Name;
				assetToEdit.Description = asset.Description;
				assetToEdit.Author = asset.Author;
				assetToEdit.ImageUrl = assetToEdit.ImageUrl;

				var catToDelete = _context.Assets.Include(c => c.Categories)
										.FirstOrDefault(p => p.Id == id);

				List<Category> tempList = new List<Category>();

				foreach (var item in catToDelete.Categories)
				{
					tempList.Add(item);
				}

				foreach (var cat in tempList)
				{
					catToDelete.Categories.Remove(cat);
				}

				Category? catToAdd = new Category();
				foreach (var item in CategoryIds)
				{
					int castItem = Int32.Parse(item);
					catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);

					if (catToAdd != null)
					{
						assetToEdit.Categories.Add(catToAdd);
					}

				}

				_context.Assets.Update(assetToEdit);
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
            if (id == null || _context.Assets == null)
            {
                return NotFound();
            }

            var asset = await _context.Assets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (asset == null)
            {
                return NotFound();
            }

            return View(asset);
        }

        // POST: AssetController/Delete/5

        // POST: Db/Delete/5
        [HttpPost, ActionName("Delete")]
		[HttpDelete]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, IFormCollection collection)
        {
            if (_context.Assets == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Assets' is null.");
            }
            var cat = await _context.Assets.FindAsync(id);
            if (cat != null)
            {
                _context.Assets.Remove(cat);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

		// Den här fungerar för variabel mängd med uppladdade filer.


		public IActionResult Upload()
		{

			UploadAssetsViewModel umfm = new UploadAssetsViewModel();

			ViewBag.CategoryList = new SelectList(_context.Categories, "Id", "Name");

			return View(umfm);
		}


        [HttpPost]
        public IActionResult Upload(UploadAssetsViewModel model)
        {
						
            if (ModelState.IsValid)
            {
                model.IsResponse = true;
                if (model.ImagesUp.Count > 1)
                {
                    foreach (var file in model.ImagesUp)
                    {

                        string path = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(webHostEnvironment.WebRootPath, "Uploads"));

                        //create folder if not exist
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        string fileNameWithPath = Path.Combine(path, file.FileName);

                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    model.IsSuccess = true;
                    model.Message = "Assets upload successfully";
                }
                else if (model.ImagesUp.Count > 0)
                {
                    foreach (var file in model.ImagesUp)
                    {

                        string path = Path.Combine(Directory.GetCurrentDirectory(), Path.Combine(webHostEnvironment.WebRootPath, "Uploads"));

                        //create folder if not exist
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);


                        string fileNameWithPath = Path.Combine(path, file.FileName);

                        using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }
                    model.IsSuccess = true;
                    model.Message = "File upload successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Please select files";
                }
            }
            return View("Upload", model);
        }

        public IActionResult MultipleAssets()
        {

            CreateMultipleAssetsViewModel umfm = new CreateMultipleAssetsViewModel();

            ViewBag.CategoryList = new SelectList(_context.Categories, "Id", "Name");

            return View(umfm);
        }
        [HttpPost]
		public IActionResult MultipleAssets(CreateMultipleAssetsViewModel assets, List<string> Categories)
        {
            CreateMultipleAssetsViewModel cmavm = new CreateMultipleAssetsViewModel();

            ModelState.Remove("Id");
            //ModelState.Remove("ImageUrl");
            if (ModelState.IsValid)
            {
                if (assets.ImageUp != null)
                {
                    string? uniqueFileName = null;
                    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads");
                    foreach (var file in assets.ImageUp)
                    {
                        
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        //string path = Path.Combine(Directory.GetCurrentDirectory(), uploadsFolder);

                        //create folder if not exist
                        //if (!Directory.Exists(filePath))
                        //    Directory.CreateDirectory(filePath)w;

                        if (System.IO.File.Exists(filePath))
                        {
                            System.IO.File.Copy(filePath, "~/Uploads");
                        }

                        //string fileNameWithPath = Path.Combine(filePath, file.FileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }

                        assets.ImageUrl = "/Uploads/" + uniqueFileName;

                        var AssetToAdd = new Asset()
                        {
                            Name = uniqueFileName,
                            Description = assets.Description,
                            Author = assets.Author,
                            ImageUrl = assets.ImageUrl
                        };
              

                        Category? catToAdd = new Category();
                        foreach (var item in Categories)
                        {
                            int castItem = Int32.Parse(item);
                            catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);

                            if (catToAdd != null)
                            {
                                AssetToAdd.Categories.Add(catToAdd);
                            }

                        }

                        _context.Assets.Add(AssetToAdd);
                        _context.SaveChanges();

                    }
                }

                return RedirectToAction(nameof(Index));
            }
            else
            {
                if (assets.Categories.Count == 0)
                {
                    ViewBag.CategoryError = "Category is Required";
                }

                var categories = _context.Categories;
                ViewBag.CategoryList = new SelectList(categories, "Id", "Name");

                return View(cmavm);
            }
        }
    }

}