using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;



namespace PostApplication.Models  
{
    public class UserModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

    }
    public class LoginViewModel
     {
    public UserModel? Input { get; set; }
     }
}
