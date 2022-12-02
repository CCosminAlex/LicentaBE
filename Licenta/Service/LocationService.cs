using Licenta.Entity.DTO;
using Licenta.Entity;
using Licenta.Helper;
using Licenta.Repository;

namespace Licenta.Service
{
    public class LocationService
    {
        private readonly LocationRepository locationRepository;

        public LocationService(ApplicationDbContext applicationDbContext)
        {
            locationRepository = new LocationRepository(applicationDbContext);
        }

        public void Create(LocationDto locationDto)
        {

            Location location = new Location()
            {
                LocationId = Guid.NewGuid(),
                Date = locationDto.Date,
                City = locationDto.City,
                Street= locationDto.Street,
                Number =locationDto.Number
            };

            locationRepository.Create(location);


        }

        public List<LocationDto> GetAll()
        {
            var locations = locationRepository.GetAll();
            List<LocationDto> result = new List<LocationDto>();
            foreach (Location Location in locations)
            {
                result.Add(new LocationDto() { City = Location.City, Street = Location.Street, Number = Location.Number, Date=Location.Date, Id=Location.LocationId });
            }
            return result;
        }
    }
}
