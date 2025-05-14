using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "Admin")]  // This ensures only authenticated users can access this page
public class ManageController : Controller
{
    [HttpGet]
    public IActionResult PersonalData()
    {
        if (!User.IsInRole("Admin"))
        {
            return RedirectToAction("AccessDenied");  // Redirect to Login if not authenticated
        }
        return View();
    }
}