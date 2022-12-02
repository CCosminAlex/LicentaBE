using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name: "partners")]
    public class Partners
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }

        public int Discount { get; set; }
    }
}
