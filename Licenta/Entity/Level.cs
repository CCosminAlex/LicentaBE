using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name: "level")]
    public class Level
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int Scor_start { get; set; }
        public int Scor_end { get; set; }
    }
}
