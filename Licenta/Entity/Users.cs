using Microsoft.AspNetCore.Identity;

namespace Licenta.Entity
{
    public class Users : IdentityUser
    {
        public string Name {get;set;}
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Score { get; set; }

    }
}
