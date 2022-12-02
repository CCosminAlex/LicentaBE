using Licenta.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Licenta.Helper
{
    public class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {


        }
        public DbSet<Voluntary> Voluntarys { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User_Voluntarys> User_Voluntarys{get;set;}
        public DbSet<Partners> Partners { get; set; }
        public DbSet<Level> Levels { get; set; }
    }
}
