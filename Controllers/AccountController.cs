using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Login(string returnUrl = null)
    {
        if (User.Identity.IsAuthenticated)
        {
            // Redirect to home or another page if already logged in
            return RedirectToAction("Index", "Home");
        }

        // Logic for Login page
        return View();
    }

    [AllowAnonymous]
    public IActionResult Register()
    {
        // Example: Only allow registration if user is not authenticated
        if (User.Identity.IsAuthenticated)
        {
            return RedirectToAction("Index", "Home");
        }

        return View();
    }
}
