using Microsoft.AspNetCore.Components.Routing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name:"voluntary")]
    public class Voluntary
    {
        [Key]
        public Guid Id { get; set; }

        public virtual Users Company { get; set; }
        public string Name { get; set; }

        public int Reward { get; set; }

        public virtual Location Location { get; set; }
    }
}
