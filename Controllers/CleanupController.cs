using GoshehArtWebApp.Data;
using GoshehArtWebApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("admin/cleanup")]
    public class CleanupController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly FilePathProvider _filePathProvider;

        public CleanupController(ApplicationDbContext context, FilePathProvider filePathProvider)
        {
            _context = context;
            _filePathProvider = filePathProvider;
        }

        [HttpPost("cleanup-orphans")]
        public async Task<IActionResult> CleanupOrphanFiles()
        {
            var cleanup = new OrphanAnnihilator(_context, _filePathProvider);
            await cleanup.RemoveUnusedFilesAsync();
            return Ok("Orphan file cleanup completed.");
        }

        [HttpGet("cleanup-orphans")]
        public IActionResult ConfirmCleanup()
        {
            return View(); // Optional: simple Razor page to confirm
        }
    }
}
