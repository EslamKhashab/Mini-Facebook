using System.ComponentModel.DataAnnotations;

namespace MiniFacebook.ViewModel.Auth
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
