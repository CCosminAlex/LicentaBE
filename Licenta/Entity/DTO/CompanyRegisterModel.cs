using System.ComponentModel.DataAnnotations;

namespace Licenta.Entity.DTO
{
    public class CompanyRegisterModel
    {
        [Required(ErrorMessage = "Error Username is required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Error Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Error FirstName is required")]
        public string CompanyName { get; set; }

       

        [Required(ErrorMessage = "Error email is required")]
        public string Email { get; set; }


        [Required]
        public string Address { get; set; }

    }
}
