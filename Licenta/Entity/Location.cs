using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Licenta.Entity
{
    [Table(name: "location")]
    public class Location
    {
        [Key]
        [JsonPropertyName("id")]
        public Guid LocationId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public int Number { get; set; }

    }   
}
