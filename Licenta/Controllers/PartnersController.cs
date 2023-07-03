using Licenta.Entity.DTO;
using Licenta.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnersController : ControllerBase
    {
        private readonly PartnersService partnersService;

        // GET: api/<PartnersController>
        [HttpGet]
        public IEnumerable<PartnersDTO> Get()
        {
          return  partnersService.GetAll();
        }

        // GET api/<PartnersController>/5
        [HttpGet("{id}")]
        public PartnersDTO Get(Guid id)
        {
            return partnersService.GetById(id);
        }

        // POST api/<PartnersController>
        [HttpPost]
        public void Post([FromBody] PartnersDTO value)
        {
            partnersService.Create(value);
        }


        // DELETE api/<PartnersController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            partnersService.Delete(id);
        }
    }
}
