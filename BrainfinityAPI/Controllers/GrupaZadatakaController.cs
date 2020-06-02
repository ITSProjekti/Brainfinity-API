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
    public class GrupaZadatakaController : ControllerBase
    {
        private readonly IGrupaZadatakaService _gzs;

        public GrupaZadatakaController(IGrupaZadatakaService gzs)
        {
            _gzs = gzs;
        }

        [HttpGet("{takmicenjeId}")]
        public IActionResult GetSveGrupeZadataka(int takmicenjeId)
        {
            return Ok(_gzs.GetSveGrupeZadataka(takmicenjeId));
        }

        [HttpGet]
        [Route("Grupa/{id}")]
        public IActionResult GetGrupaZadataka(int id)
        {
            var grupaZadataka = _gzs.GetGrupaZadataka(id);
            if (grupaZadataka == null)
            {
                return NotFound();
            }

            return Ok(grupaZadataka);
        }

        [HttpPost]
        public IActionResult NovaGrupaZadataka([FromBody]PostGrupaZadatakaDto grupaZadataka)
        {
            if (_gzs.NovaGrupaZadataka(grupaZadataka))
            {
                return Ok(grupaZadataka);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}