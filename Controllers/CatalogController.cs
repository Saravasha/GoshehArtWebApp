using GoshehArtWebApp.Controllers;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using GoshehArtWebApp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using System.Linq;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Routing.Constraints;

namespace GoshehArtWebApp.Controllers
{
	public class CatalogController : Controller
	{

		private readonly ApplicationDbContext _context;
		private readonly IWebHostEnvironment webHostEnvironment;

		public CatalogController(ApplicationDbContext context, IWebHostEnvironment webHost)
		{
			_context = context;
			webHostEnvironment = webHost;
		}
		public IActionResult Success()
		{
			return View();
		}

		// Den här fungerar för variabel mängd med uppladdade filer.
        [HttpPost]
        public IActionResult Upload(UploadAssetsViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.IsResponse = true;
                if (model.ImagesUp.Count > 0)
                {
                    foreach (var file in model.ImagesUp)
                    {

                        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Files");

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
                    model.Message = "Files upload successfully";
                }
                else
                {
                    model.IsSuccess = false;
                    model.Message = "Please select files";
                }
            }
            return View("Upload", model);
        }

        public IActionResult Upload()
		{

			UploadAssetsViewModel umfm = new UploadAssetsViewModel();
			return View(umfm);
		}

		// GET: CatalogController]
		public IActionResult Index()
		{

			var cvm = new CatalogViewModel();
			string uploadDirectory = Path.Combine(webHostEnvironment.WebRootPath, "imagesAsset","Pictures","Sidans Filer");
			List<string> localFolders = new List<string>();
			//Directory.GetDirectories(uploadDirectory, "*").ToList().new DirectoryInfo();
			foreach (var f in Directory.GetDirectories(uploadDirectory, "*"))
			{
				var dir = new DirectoryInfo(f).Name;
				localFolders.Add(dir);
			}

			foreach (var file in localFolders)
			{
				if (!_context.Categories.Any(x => x.Name == file))
				{
					_context.Categories.Update(new Category() { Name = file });
					_context.SaveChanges();
				}
			}

			FoldersContentGetter(uploadDirectory, localFolders);
			return Redirect("Asset");
		}
		private void FoldersContentGetter(string uploadDirectory, List<string> localFolders)
		{
			//string uploadDirectory = webHostEnvironment.WebRootPath + "\\imagesAsset\\Pictures\\Sidans Filer";
			//Directory.GetDirectories(uploadDirectory, "*").ToList().new DirectoryInfo();
			foreach (var folder in localFolders)
			{
				Category catToAdd = new Category();
				//var categoryId = _context.Categories.Any(c => c.Name == folder);
				//uploadDirectory = Path.Combine(uploadDirectory, folder);
				foreach (var item in Directory.GetFiles(Path.Combine(uploadDirectory,folder)))
				{
					var fileInDirectory = new FileInfo(item).Name;
					var assetName = _context.Assets.FirstOrDefault(n => n.Name == fileInDirectory);
					if (!_context.Assets.Any(x => x.Name == fileInDirectory))
					{
						//catToAdd = _context.Categories.FirstOrDefault(c => c.Name == folder);
						//_context.Assets.Update(new Asset() { Name = fileInDirectory, Author = User.Identity.Name, CategoryId = cat.Id, });
						var fileName = "/imagesAsset/Pictures/Sidans Filer/" + folder + "/" + fileInDirectory;

						Asset assetStage = new Asset()
						{
							Name = fileInDirectory,
							Description = folder,
							Author = User.Identity.Name,
							ImageUrl = fileName
						};
						foreach (var cat in localFolders)
						{
							catToAdd = _context.Categories.FirstOrDefault(c => c.Name == folder);
							if (catToAdd != null)
							{
								assetStage.Categories.Add(catToAdd);
							}
						}
						_context.Assets.Add(assetStage);
					}
				}

			}
			_context.SaveChanges();
		}
	}
}