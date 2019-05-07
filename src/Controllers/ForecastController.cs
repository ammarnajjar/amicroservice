using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using amicroservice.Models.Adapter;
using amicroservice.Services;

namespace amicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ForecastController : ControllerBase
    {

        private ForecastRepository computerRepository;

        public ForecastController()
        {
            this.computerRepository = new ForecastRepository();
        }

        // GET api/computer
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return this.computerRepository.Temperature;
        }
    }
}
