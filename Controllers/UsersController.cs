using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using amicroservice.Models;
using amicroservice.Services;

namespace amicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private UsersRepository usersRepository;

        public UsersController()
        {
            this.usersRepository = new UsersRepository();
        }

        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return this.usersRepository.AllUsers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
