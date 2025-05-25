using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using System.Diagnostics;
using GoshehArtWebApp.Services;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class AssetController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AssetController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHostEnvironment = webHost;
        }

        private async Task<string?> GenerateVideoThumbnailAsync(string videoPath, string videoFileName)
        {
            if (!Directory.Exists(FilePathProvider.ThumbnailsRoot))
            {
                Directory.CreateDirectory(FilePathProvider.ThumbnailsRoot);
            }

            string thumbnailFileName = Path.GetFileNameWithoutExtension(videoFileName) + "_thumb.jpg";
            string thumbnailPath = Path.Combine(FilePathProvider.ThumbnailsRoot, thumbnailFileName);

            var ffmpegArgs = $"-i \"{videoPath}\" -ss 00:00:01 -vframes 1 -q:v 2 \"{thumbnailPath}\"";

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg",
                    Arguments = ffmpegArgs,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            try
            {
                process.Start();
                string stderr = await process.StandardError.ReadToEndAsync();
                await process.WaitForExitAsync();

                if (process.ExitCode != 0 || !System.IO.File.Exists(thumbnailPath))
                {
                    // Log error somewhere persistent in production
                    Console.WriteLine("FFmpeg Error:\n" + stderr);
                    return null;
                }

                return FilePathProvider.ToWebPath(thumbnailPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("FFmpeg failed: " + ex.Message);
                return null;
            }
        }



        private AssetType GetAssetTypeFromUploadedFile(string contentType)
        {
            if (contentType.StartsWith("image/"))
                return AssetType.Image;
            else if (contentType.StartsWith("video/"))
                return AssetType.Video;
            else if (contentType.StartsWith("audio/"))
                return AssetType.Audio;
            else
                return AssetType.Other;
        }
        private async Task<(string PhysicalPath, string WebPath)?> UploadedFile(IFormFile? file)
        {
            if (file == null) return null;

            if (!Directory.Exists(FilePathProvider.UploadsRoot))
            {
                Directory.CreateDirectory(FilePathProvider.UploadsRoot);
            }

            string uniqueFileName = Guid.NewGuid() + "_" + file.FileName;
            string physicalFilePath = Path.Combine(FilePathProvider.UploadsRoot, uniqueFileName);

            using (var fileStream = new FileStream(physicalFilePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            string webPath = FilePathProvider.ToWebPath(physicalFilePath);
            return (physicalFilePath, webPath);
        }



        public IActionResult Index(string searchString, DateOnly? fromDate, DateOnly? toDate)
        {
            var assets = _context.Assets
                .Include(a => a.Categories)
                .ToList();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                searchString = searchString.ToLower();

                assets = assets.Where(a =>
                    (a.Name?.ToLower().Contains(searchString) ?? false) ||
                    (a.Description?.ToLower().Contains(searchString) ?? false) ||
                    (a.Location?.ToLower().Contains(searchString) ?? false) ||
                    (a.Author?.ToLower().Contains(searchString) ?? false) ||
                    (a.Date.HasValue && a.Date.Value.ToString("yyyy-MM-dd").Contains(searchString)) ||
                    a.Categories.Any(c => c.Name.ToLower().Contains(searchString))
                ).ToList();
            }

            // Apply date range filtering
            if (fromDate.HasValue)
            {
                assets = assets.Where(a => a.Date.HasValue && a.Date.Value >= fromDate.Value).ToList();
            }

            if (toDate.HasValue)
            {
                assets = assets.Where(a => a.Date.HasValue && a.Date.Value <= toDate.Value).ToList();
            }

            var avm = new AssetViewModel
            {
                Assets = assets,
                FromDate = fromDate,
                ToDate = toDate
            };

            ViewData["CurrentFilter"] = searchString;
            return View(avm);
        }

        // GET: AssetController/Details/5
        public IActionResult Details(int id)
        {
            Models.Asset? asset = _context.Assets
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

        [HttpPost]
        public async Task<IActionResult> Create(CreateAssetViewModel asset, List<string> Categories)
        {
            CreateAssetViewModel cavm = new CreateAssetViewModel();

            var uploadResult = await UploadedFile(asset.FileUp);
            string? physicalFilePath = uploadResult?.PhysicalPath;
            string? webFilePath = uploadResult?.WebPath;

            asset.FileUrl = webFilePath;

            string? thumbPath = null;

            if (asset.FileUp != null && asset.FileUp.ContentType.StartsWith("video/") && physicalFilePath != null)
            {
                thumbPath = await GenerateVideoThumbnailAsync(physicalFilePath, Path.GetFileName(physicalFilePath));
            }

            if (ModelState.IsValid)
            {
                var assetType = asset.FileUp != null ? GetAssetTypeFromUploadedFile(asset.FileUp.ContentType) : AssetType.Other;

                var AssetToAdd = new Asset()
                {
                    Name = asset.Name,
                    Description = asset.Description,
                    Author = asset.Author,
                    FileUrl = webFilePath,
                    ThumbnailUrl = thumbPath,
                    Location = asset.Location,
                    Date = asset.Date,
                    Type = assetType
                };

                foreach (var item in Categories)
                {
                    int castItem = Int32.Parse(item);
                    var catToAdd = _context.Categories.FirstOrDefault(c => c.Id == castItem);
                    if (catToAdd != null)
                        AssetToAdd.Categories.Add(catToAdd);
                }
                

                await _context.Assets.AddAsync(AssetToAdd);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            if (asset.Categories.Count == 0)
                ViewBag.CategoryError = "Category is Required";

            ViewBag.CategoryList = new SelectList(_context.Categories, "Id", "Name");

            return View(cavm);
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            EditAssetViewModel cavm = new EditAssetViewModel();
            Models.Asset? asset = _context.Assets
                .Include(c => c.Categories)
                .FirstOrDefault(p => p.Id == id);

            if (asset == null)
            {
                return NotFound();
            }

            List<int> categoriesIds = asset.Categories.Select(c => c.Id).ToList();

            cavm.Name = asset.Name;
            cavm.Description = asset.Description;
            cavm.FileUrl = asset.FileUrl;
            cavm.Author = asset.Author;
            cavm.CategoryIds = categoriesIds;
            cavm.Location = asset.Location;
            cavm.Date = asset.Date;
            cavm.Type = asset.Type;  // <--- Set the AssetType here

            var categories = _context.Categories;
            ViewBag.CategoryList = new MultiSelectList(categories, "Id", "Name");

            return View(cavm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditAssetViewModel asset, string ExistingFileUrl)
        {
            var assetToEdit = _context.Assets
                .Include(a => a.Categories)
                .FirstOrDefault(a => a.Id == asset.Id);

            if (assetToEdit == null)
            {
                return NotFound();
            }

            ModelState.Remove("FileUp");

            if (ModelState.IsValid)
            {
                assetToEdit.Name = asset.Name;
                assetToEdit.Description = asset.Description;
                assetToEdit.Author = asset.Author;
                assetToEdit.Location = asset.Location;
                assetToEdit.Date = asset.Date;

                if (asset.FileUp != null)
                {
                    var uploadResult = await UploadedFile(asset.FileUp);
                    string? physicalFilePath = uploadResult?.PhysicalPath;
                    string? webFilePath = uploadResult?.WebPath;

                    assetToEdit.FileUrl = webFilePath;
                    assetToEdit.Type = GetAssetTypeFromUploadedFile(asset.FileUp.ContentType);

                    string? thumbPath = null;

                    if (asset.FileUp.ContentType.StartsWith("video/") && physicalFilePath != null)
                    {
                        thumbPath = await GenerateVideoThumbnailAsync(physicalFilePath, Path.GetFileName(physicalFilePath));
                    }

                    assetToEdit.ThumbnailUrl = thumbPath;
                }
                else
                {
                    assetToEdit.FileUrl = ExistingFileUrl;
                }

                assetToEdit.Categories.Clear();
                if (asset.CategoryIds != null)
                {
                    foreach (var categoryId in asset.CategoryIds)
                    {
                        var category = _context.Categories.FirstOrDefault(c => c.Id == categoryId);
                        if (category != null)
                        {
                            assetToEdit.Categories.Add(category);
                        }
                    }
                }

                _context.Assets.Update(assetToEdit);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            var categories = await _context.Categories.ToListAsync();

            ViewBag.CategoryList = new MultiSelectList(categories, "Id", "Name", asset.CategoryIds);

            return View(asset);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Assets == null)
            {
                return NotFound();
            }

            var asset = await _context.Assets.Include(c => c.Categories)
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

        [HttpGet]
        public IActionResult CreateMultipleAssets()
        {
            var vm = new CreateMultipleAssetsViewModel();
            ViewBag.CategoryList = new SelectList(_context.Categories, "Id", "Name");
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMultipleAssets(CreateMultipleAssetsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CategoryList = new SelectList(_context.Categories, "Id", "Name");
                return View(model);
            }

            string uploadsFolder = FilePathProvider.UploadsRoot;

            foreach (var file in model.FileUp!)
            {
                var uniqueFileName = Guid.NewGuid() + "_" + Path.GetFileName(file.FileName);
                var physicalFilePath = Path.Combine(uploadsFolder, uniqueFileName);

                using var stream = new FileStream(physicalFilePath, FileMode.Create);
                await file.CopyToAsync(stream);

                string? thumbPath = null;

                if (file.ContentType.StartsWith("video/"))
                {
                    thumbPath = await GenerateVideoThumbnailAsync(physicalFilePath, uniqueFileName);
                }

                var asset = new Asset
                {
                    Name = uniqueFileName,
                    Description = model.Description,
                    Author = model.Author,
                    FileUrl = FilePathProvider.ToWebPath(physicalFilePath),
                    ThumbnailUrl = thumbPath,
                    Location = model.Location,
                    Date = model.Date,
                    Type = GetAssetTypeFromUploadedFile(file.ContentType)
                };

                foreach (var catId in model.Categories)
                {
                    if (int.TryParse(catId, out var id))
                    {
                        var category = _context.Categories.FirstOrDefault(c => c.Id == id);
                        if (category != null)
                            asset.Categories.Add(category);
                    }
                }

                _context.Assets.Add(asset);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }

}