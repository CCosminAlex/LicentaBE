using Licenta.Entity.DTO;
using Licenta.Helper;
using Licenta.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly LocationService locationService;

        public LocationController(ApplicationDbContext dbContext)
        {
            locationService = new LocationService(dbContext);
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<LocationDto> Get()
        {
            return locationService.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] LocationDto location)
        {
            locationService.Create(location);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]  LocationDto locationDto)
        {
            locationService.Edit(locationDto);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            locationService.Delete(id); 
        }
    }
}
