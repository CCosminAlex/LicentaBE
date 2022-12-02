using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Licenta.Entity.DTO
{
    public class LoginModel
    {
        [Required (ErrorMessage= "Error Username is required" )] 
        public string Username { get; set; }
        [Required(ErrorMessage = "Error Password is required")]
        public string Password { get; set; }

    }
}
