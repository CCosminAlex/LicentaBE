using Licenta.Entity;
using Licenta.Helper;

namespace Licenta.Repository
{
    public class LocationRepository
    {

        private ApplicationDbContext dbContext;

        public LocationRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public void Create(Location location)
        {
            dbContext.Locations.Add(location);
            dbContext.SaveChanges();
        }
        public List<Location> GetAll()
        {
            return dbContext.Locations.ToList();

        }
        //for edit
        public Location GetById(Guid LocationId)
        {
            return dbContext.Locations.FirstOrDefault(x => x.LocationId == LocationId);
        }

        public void Edit(Location location)
        {
            var editLocation = dbContext.Locations.FirstOrDefault(x => x.LocationId == location.LocationId);
            editLocation.Street = location.Street;
            editLocation.City = location.City;
            editLocation.Number = location.Number;
            editLocation.Date = location.Date;
          
            dbContext.Locations.Update(editLocation);
            dbContext.SaveChanges();

        }
        public void Delete(Guid id)
        {
            var location = dbContext.Locations.FirstOrDefault(x => x.LocationId == id);
            dbContext.Locations.Remove(location);
            dbContext.SaveChanges();
        }
    }
}
