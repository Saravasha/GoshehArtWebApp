using GoshehArtWebApp.Areas.Identity;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

public class RegisterViewModel : IdentityUser
{


    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
