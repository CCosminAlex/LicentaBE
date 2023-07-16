using Licenta.Entity;
using Licenta.Helper;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Licenta.Repository
{
    public class UserRepository
    {
        private ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public void Create(Entity.Users user)
        {
            var existUser = dbContext.Users.FirstOrDefault(x => x.Sub_ID == user.Sub_ID);
            if (existUser == null)
            {
                
                dbContext.Users.Add(user);
            }
            else
            {
                existUser.Name = user.Name;
                existUser.Description = user.Description;
                existUser.IsCompany = user.IsCompany;
                existUser.Address = user.Address;
                existUser.BirthDate = user.BirthDate;
                existUser.Score = user.Score;
                dbContext.Users.Update(existUser);
            }

            dbContext.SaveChanges();
        }

        public void Delete(string subID)
        {
            var user = dbContext.Users.FirstOrDefault(x => x.Sub_ID == subID);
            if (user != null)
            {
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
        }

        public IEnumerable<Entity.Users> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public Entity.Users GetUser(string subID)
        {
            return dbContext.Users.FirstOrDefault(x => x.Sub_ID == subID);
        }

    }
}
