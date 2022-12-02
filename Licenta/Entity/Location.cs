using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name: "location")]
    public class Location
    {
        [Key]
        public Guid LocationId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public int Number { get; set; }
        public DateTime Date { get; set; }

    }   
}
