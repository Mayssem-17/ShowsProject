using System.ComponentModel.DataAnnotations;

namespace ShowsProject.Models.Authentification.SignUp
{
    public class Register
    {

        [Required(ErrorMessage ="username is required !")]
        public string? UserName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Email is required !")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Password required !")]
        public string? Password { get; set; }
    
    
    }
}
