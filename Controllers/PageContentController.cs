using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;
using System.IO;

namespace GoshehArtWebApp.Controllers
{
    [Authorize]
    public class PageContentController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {

            string _uploadsFolder = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).ToString(), "Uploads");
            if (!Directory.Exists(_uploadsFolder))
            {
                Directory.CreateDirectory(_uploadsFolder);
            }
            if (file != null && file.Length > 0)
            {

                // Generate a unique file name
                var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(file.FileName);
                var filePath = Path.Combine(_uploadsFolder, fileName);

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Copy(filePath, "Uploads");
                }
                // Save the file to the server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }


                if (Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") == "Production" || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                {

                    var apiURL = Environment.GetEnvironmentVariable("PRODUCTION_URL_TARGET");
                    // Return the URL for Summernote to insert the image
                    var fileUrl = $"{ apiURL}/Uploads/{fileName}";
                    return Json(new { success = true, url = fileUrl });
                }
                else
                {
                    var fileUrl = $"/Uploads/{fileName}";
                    return Json(new { success = true, url = fileUrl });
                }
            }

            return Json(new { url = "" });
        }
    }
}
