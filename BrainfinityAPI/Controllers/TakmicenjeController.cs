using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrainfinityAPI.Services;
using BrainfinityAPI.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace BrainfinityAPI.Controllers
{
    [Authorize(Roles = "Supervizor")]
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
            GetTakmicenjeDto takmicenje = ts.GetTakmicenje(id);

            if (takmicenje == null)
            {
                return NotFound();
            }
            return Ok(takmicenje);
        }

        [Authorize]
        [HttpGet]
        public ObjectResult GetAll()
        {
            return Ok(ts.GetTakmicenjes());
        }

        [HttpPost]
        public ObjectResult Post([FromBody] PostTakmicenjeDto takmicenje)
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

        [HttpPut("{id}")]
        public IActionResult PutUpdateTakmicenje([FromBody] PostTakmicenjeDto takmicenje, int id)
        {
            if (ts.PutUpdateTakmicenje(takmicenje, id))
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