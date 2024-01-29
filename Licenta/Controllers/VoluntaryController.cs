using Licenta.Entity;
using Licenta.Entity.DTO;
using Licenta.Helper;
using Licenta.Repository;
using Licenta.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoluntaryController : ControllerBase
    {
        private readonly VoluntaryService voluntaryService;

        public VoluntaryController(ApplicationDbContext dbContext)
        {
            voluntaryService = new VoluntaryService(dbContext);
        }
        // GET: api/<VoluntaryController>
        [HttpGet]
        public IEnumerable<VoluntaryDto> Get()
        {
            return voluntaryService.GetAll();
        }

        // GET api/<VoluntaryController>/5
        [HttpGet("{id}")]
        public Voluntary Get(Guid id)
        {
            return voluntaryService.FindById(id);
        }

        [HttpGet("search")]
        public IEnumerable<VoluntaryDto> SearchVol(string? name, Guid? city, DateTime? date)
        {
            return voluntaryService.Search(name, city, date);
        }

        // POST api/<VoluntaryController>
        [HttpPost("{id}")]
        public void Post([FromBody] VoluntaryDto voluntaryDto, string id)
        {
            voluntaryService.Create(voluntaryDto, id);
        }

        // PUT api/<VoluntaryController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] VoluntaryDto voluntaryDto) 
        {
            voluntaryService.Edit(voluntaryDto);
        }

        // DELETE api/<VoluntaryController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            voluntaryService.Delete(id);
        }

        [HttpPost("apply")]
        public void Apply([FromBody] UserVoluntaryDTO userVoluntaryDTO)
        {
            voluntaryService.Apply(userVoluntaryDTO);
        }

        // GET api/<VoluntaryController>/5
        [HttpGet("company/{id}")]
        public IEnumerable<VoluntaryDto> GetByCompany(string id)
        {
            return voluntaryService.FindByCompanyId(id);
        }

    }
}
