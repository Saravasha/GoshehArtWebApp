using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GoshehArtWebApp.Controllers
{
    public class UserController : Controller
    {
        readonly UserManager<IdentityUser> _userManager;
        public UserController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;


        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
    }
}
