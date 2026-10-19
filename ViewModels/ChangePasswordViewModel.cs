using System.ComponentModel.DataAnnotations;

namespace HelpDeskWeb.ViewModels
{
    public class ChangePasswordViewModel
    {
       
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max. {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
<<<<<<< HEAD
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
=======
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
>>>>>>> respaldo-remoto-origin-main
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
<<<<<<< HEAD
        public string ConfirmPassword { get; set; }
=======
        public string ConfirmNewPassword { get; set; }
>>>>>>> respaldo-remoto-origin-main



    }
}
