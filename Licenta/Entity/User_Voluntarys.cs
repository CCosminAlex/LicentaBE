using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Licenta.Entity
{
    [Table(name: "user_voluntarys")]
    public class User_Voluntarys
    {
        [Key]
        public Guid Id { get; set; }
        public Guid VolunteerID { get; set; }
        public Guid VoluntaryID { get; set; }
        public bool IsRewarded { get; set; }
    }
}
