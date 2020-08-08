using System.ComponentModel.DataAnnotations;

namespace MiniFacebook.ViewModel.Auth
{
    public class ForgetPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
