using Licenta.Entity;
using Licenta.Helper;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

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
            return dbContext.Voluntarys.Include(x => x.Location).ToList();

        }
        public List<Voluntary> GetComapnyVoluntarys(Guid CompanyId)
        {
            return dbContext.Voluntarys.Where(x => x.Company.ID == CompanyId).ToList();

        }

        public List<Voluntary> SearchComapnyVoluntarys(Guid CompanyId, DateTime startTime, string city, string name)
        {
            return dbContext.Voluntarys.FromSqlRaw($"Select * From dbo.Voluntarys where CompanyId='{CompanyId}' and StartDate >= '{startTime}' and Name like '%{name}%'").ToList();
        }

        public List<Voluntary> SearchVoluntarys(DateTime? startTime, Guid? city, string name)
        {
            string startTimeSql = "";

            string nameSql = "";
            if (startTime == null)
            {
                startTime = DateTime.MinValue;
            }
            startTimeSql = $"\"StartDate\" >= '{startTime.Value.ToString("yyyy-mm-dd")}'";
            if (!string.IsNullOrEmpty(name))
                nameSql = $"\"Name\" like '%{name}%'";
            if (city != null)
            {
                string citySql = $"\"LocationId\" = '{city.ToString().ToLower()}'";
                return dbContext.Voluntarys.FromSqlRaw(string.Format("Select * From voluntary where {0}", name != null ? string.Join("AND", startTimeSql, nameSql, citySql) : string.Join("AND", citySql, startTimeSql)))
                    .Include(v => v.Location)
                    .ToList();
            }

            return dbContext.Voluntarys.FromSqlRaw(string.Format("Select * From voluntary where {0}", name != null ? string.Join("AND", startTimeSql,nameSql) : startTimeSql))
                .Include(v => v.Location)
                .ToList();
        }

        //for edit
        public Voluntary GetById(Guid voluntaryId)
        {
            var voluntary = dbContext.Voluntarys.Include(v => v.Location).Include(x => x.Company).FirstOrDefault(x => x.Id == voluntaryId);
            return voluntary;
        }

        public void Edit(Voluntary voluntary)
        {
            var newVoluntary = dbContext.Voluntarys.FirstOrDefault(x => x.Id == voluntary.Id);
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
