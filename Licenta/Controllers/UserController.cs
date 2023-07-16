using Licenta.Entity.DTO;
using Licenta.Helper;
using Licenta.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Licenta.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(ApplicationDbContext dbContext)
        {
            this.userService = new UserService(dbContext);
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UserDTO> Get()
        {
           return userService.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UserDTO Get(string id)
        {
            return userService.Get(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserDTO value)
        {
            userService.CreateOrUpdate(value);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] UserDTO value)
        {
            userService.CreateOrUpdate(value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            userService.Delete(id);
        }
    }
}
