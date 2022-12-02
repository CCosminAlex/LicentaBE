using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name: "user_voluntarys")]
    public class User_Voluntarys
    {
        [Key]
        public Guid Id { get; set; }
        public Users Volunteer { get; set; }
        public Voluntary Voluntary { get; set; }
    }
}
