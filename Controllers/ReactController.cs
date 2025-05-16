using Microsoft.AspNetCore.Mvc;
using GoshehArtWebApp.Data;
using GoshehArtWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;


namespace GoshehArtWebApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ReactController : ControllerBase
    {
        readonly ApplicationDbContext _context;
        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("asset")]
        public List<Asset> GetAssets()
        {
            List<Asset> assets = new List<Asset>();
            assets = _context.Assets.Include(c => c.Categories).ToList();
            return assets;
        }
         
        [HttpGet("page")]
        public List<Page> GetPages()
        {
            List<Page> pages = new List<Page>();
            pages = _context.Pages.Include(c => c.Contents).ToList();
            return pages;
        }
     

    }
}