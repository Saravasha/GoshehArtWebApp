using System.ComponentModel.DataAnnotations;

public class ChangeEmailViewModel
{
    public string CurrentEmail { get; set; }

    [Required]
    [EmailAddress]
    [Display(Name = "New Email")]
    public string NewEmail { get; set; }
}
