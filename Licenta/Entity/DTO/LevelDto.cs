using System.ComponentModel.DataAnnotations;

namespace Licenta.Entity.DTO
{
    public class LevelDto
    {
    
        public Guid Id { get; set; }

        [Required(ErrorMessage = " Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Starting Score is required")]
        public int Scor_start { get; set; }
        [Required(ErrorMessage = "Ending Score is required")]
        public int Scor_end { get; set; }
    }
}
