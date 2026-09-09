using System.ComponentModel.DataAnnotations;
namespace HelpDeskWeb.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Passsword is required.")]
        [DataType(DataType.Password)]
        public string Passaword { get; set; }

        [Display(Name ="Remember me?")]

        public bool RememberMe { get; set; } 

    }
}
