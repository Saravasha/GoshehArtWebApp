﻿using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;

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
				string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imagesAsset");
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

			return "/imagesAsset/" + uniqueFileName;
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
		[HttpPost]
		//[ValidateAntiForgeryToken]
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
                return Problem("Entity set 'ApplicationDbConext.Assets'  is null.");
            }
            var cat = await _context.Assets.FindAsync(id);
            if (cat != null)
            {
                _context.Assets.Remove(cat);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}