using Licenta.Entity;
using Licenta.Helper;
using Microsoft.EntityFrameworkCore;


namespace Licenta.Repository
{
    public class VoluntaryRepository
    {
        private ApplicationDbContext dbContext;
        
        public VoluntaryRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void Create(Voluntary voluntary, Guid CompanyId)
        {
            var Company = dbContext.Users.FirstOrDefault(x => x.ID == CompanyId);
            var location = dbContext.Locations.FirstOrDefault(x => x.LocationId == voluntary.Location.LocationId);
            voluntary.Location = location;
            voluntary.Company = Company;
            dbContext.Voluntarys.Add(voluntary);
            dbContext.SaveChanges();
        }
        public List<Voluntary> GetAll()
        {
            return dbContext.Voluntarys.Include(x=>x.Location).ToList();

        }
        public List<Voluntary> GetComapnyVoluntarys(Guid CompanyId)
        {
            return dbContext.Voluntarys.Where(x => x.Company.ID == CompanyId).ToList();

        }
        //for edit
        public Voluntary GetById(Guid voluntaryId)
        {
            return dbContext.Voluntarys.FirstOrDefault(x => x.Id == voluntaryId);
        }

        public void Edit(Voluntary voluntary)
        {
            var newVoluntary = dbContext.Voluntarys.FirstOrDefault(x=>x.Id==voluntary.Id);
            var oldLocation = dbContext.Locations.FirstOrDefault(x => x.LocationId == voluntary.Location.LocationId);
            newVoluntary.Reward = voluntary.Reward;
            newVoluntary.Location = oldLocation;
            newVoluntary.Name = voluntary.Name;
            dbContext.Voluntarys.Update(newVoluntary);
            dbContext.SaveChanges();

        }
        public void Delete(Guid id)
        {
            var voluntary = dbContext.Voluntarys.FirstOrDefault(x => x.Id == id);
            dbContext.Voluntarys.Remove(voluntary);
            dbContext.SaveChanges();
        }
        public int GetRewardByID(Guid id)
        {
            return dbContext.Voluntarys.FirstOrDefault(v => v.Id == id).Reward;
        }
    }
}
