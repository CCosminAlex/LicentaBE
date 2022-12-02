using System.ComponentModel.DataAnnotations;

namespace Licenta.Entity.DTO
{
    public class UserRegisterModel
    {


        [Required(ErrorMessage = "Error Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Error Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Error FirstName is required")]
        public string FirstName { get; set; }
      
        [Required(ErrorMessage = "Error LastName is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Error email is required")]
        public string Email { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Address { get; set; }

    }
}
