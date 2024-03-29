﻿using Licenta.Entity.DTO;
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
                result.Add(new LocationDto() { City = Location.City, Street = Location.Street, Number = Location.Number, Id=Location.LocationId });
            }
            return result;
        }

        public void Delete(Guid id)
        {
            locationRepository.Delete(id);
        }

        public void Edit(LocationDto locationDto)
        {
            var location = new Location() {  City = locationDto.City, Number = locationDto.Number, LocationId=locationDto.Id, Street=locationDto.Street};
            locationRepository.Edit(location);
        }
    }
}
