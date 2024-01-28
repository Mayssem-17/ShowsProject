using System.ComponentModel.DataAnnotations;

namespace ShowsProject.Models.Authentification.Login
{
    public class Login
    {

        [Required(ErrorMessage = "username is required !")]
        public string? UserName { get; set; }


        [Required(ErrorMessage = "Password required !")]
        public string? Password { get; set; }

    }
}
