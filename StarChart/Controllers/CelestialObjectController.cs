using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]

    public class CelestialObjectController : ControllerBase
    {


        private readonly ApplicationDbContext _context;

        public CelestialObjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int Id)
        {
                        
            return Ok();

        }
        [HttpGet("{string:name}")]
        public IActionResult GetByName(string name)
        {

            return Ok();

        }
        [HttpGet]
        public IActionResult GetAll()
        {

            return Ok();

        }
    }
}
