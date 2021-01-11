using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrainfinityAPI.Controllers
{
    [Authorize(Roles = "Supervizor, Pregledac")]
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
            var zadaci = _zs.GetSviZadaci(grupaId);
            if (zadaci.Count() == 0)
            {
                return NotFound();
            }
            return Ok(zadaci);
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
        public IActionResult CreateZadatak([FromBody] PostZadatakDto zadatak)
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

        [HttpPut("{zadatakId}")]
        public IActionResult EditZadatak(PostZadatakDto zadatak, int zadatakId)
        {
            if (_zs.EditZadatak(zadatak, zadatakId))
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}