using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrainfinityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZadatakController : ControllerBase
    {
        private readonly IZadatakService _zs;

        public ZadatakController(IZadatakService zs)
        {
            _zs = zs;
        }

        [HttpGet("{grupaId}")]
        public IActionResult GetSviZadaci(int grupaId)
        {
            if (_zs.GetSviZadaci(grupaId) == null)
            {
                return NotFound();
            }
            return Ok(_zs.GetSviZadaci(grupaId));
        }

        [HttpGet("Id/{zadatakId}")]
        public IActionResult GetZadatak(int zadatakId)
        {
            if (_zs.GetZadatak(zadatakId) == null)
            {
                return NotFound();
            }

            return Ok(_zs.GetZadatak(zadatakId));
        }

        [HttpPost]
        public IActionResult CreateZadatak([FromBody]PostZadatakDto zadatak)
        {
            if (_zs.PostZadatak(zadatak))
                return NoContent();

            return BadRequest();
        }

        [HttpDelete("{zadatakId}")]
        public IActionResult DeleteZadatak(int zadatakId)
        {
            if (_zs.DeleteZadatak(zadatakId))
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}