using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrainfinityAPI.Services;
using BrainfinityAPI.Dtos;

namespace BrainfinityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TakmicenjeController : ControllerBase
    {
        private readonly ITakmicenjeService ts;

        public TakmicenjeController(ITakmicenjeService ts)
        {
            this.ts = ts;
        }

        [HttpGet("{id}")]
        public IActionResult GetTakmicenje(int id)
        {
            TakmicenjeDto takmicenje = ts.GetTakmicenje(id);

            if (takmicenje == null)
            {
                return NotFound();
            }
            return Ok(takmicenje);
        }

        [HttpGet]
        public ObjectResult GetAll()
        {
            return Ok(ts.GetTakmicenjes());
        }

        [HttpPost]
        public ObjectResult Post([FromBody]TakmicenjeDto takmicenje)
        {
            if (ts.PostTakmicenje(takmicenje))
            {
                return Ok(takmicenje);
            }
            else
            {
                var error = "Greska, bad request";
                return BadRequest(error);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveTakmicenje(int id)
        {
            if (ts.RemoveTakmicenje(id))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}