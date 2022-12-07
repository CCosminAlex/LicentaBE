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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VoluntaryController>
        [HttpPost]
        public void Post([FromBody] VoluntaryDto voluntaryDto, string CompanyId)
        {
            voluntaryService.Create(voluntaryDto, CompanyId);
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
    }
}
