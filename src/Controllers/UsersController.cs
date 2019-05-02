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
    }
}
