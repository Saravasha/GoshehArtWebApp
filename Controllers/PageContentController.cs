using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class PageContentController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {

            string _uploadsFolder = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).ToString(), "Uploads");

            if (file != null && file.Length > 0)
            {

                // Generate a unique file name
                var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(file.FileName);
                var filePath = Path.Combine(_uploadsFolder, fileName);

                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Copy(filePath, "~/Uploads");
                }
                // Save the file to the server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // Return the URL for Summernote to insert the image
                var fileUrl = Url.Content("~/Uploads/" + fileName);
                return Json(new { url = fileUrl });
            }

            return Json(new { url = "" });
        }
    }
}
