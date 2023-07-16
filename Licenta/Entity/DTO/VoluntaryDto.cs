using System.ComponentModel.DataAnnotations;

namespace Licenta.Entity.DTO
{
    public class VoluntaryDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Error Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error Reward is required")]
        public int Reward { get; set; }

        [Required(ErrorMessage = "Error Location is required")]
        public Location Location { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Description { get; set; }
    }
}
