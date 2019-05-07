using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using amicroservice.Models.Builder;
using amicroservice.Services;

namespace amicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {

        private ComputerRepository computerRepository;

        public ComputerController()
        {
            this.computerRepository = new ComputerRepository();
        }

        // GET api/computer
        [HttpGet]
        public ActionResult<IEnumerable<Computer>> Get()
        {
            return this.computerRepository.AllComputers;
        }
    }
}
