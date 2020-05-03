using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BrainfinityAPI.Models;
using BrainfinityAPI.Services;

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
        public ObjectResult GetTakmicenje(int id)
        {
            Takmicenje takmicenje = ts.GetTakmicenje(id);
            return Ok(takmicenje);
        }

        [HttpGet]
        public ObjectResult GetAll()
        {
            return Ok(ts.GetTakmicenjes());
        }

        [HttpPost]
        public ObjectResult Post([FromBody]Takmicenje takmicenje)
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
    }
}