using System.ComponentModel.DataAnnotations;

namespace Licenta.Entity.DTO
{
    public class LocationDto
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Street Name is required")]
        public string Street { get; set; }
        [Required(ErrorMessage = "City Name is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Error Number is required")]

        public int Number { get; set; }
        
       

    }
}
