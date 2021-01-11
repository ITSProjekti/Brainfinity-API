using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;
using BrainfinityAPI.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BrainfinityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IConfiguration _config;
        private readonly UserManager<Korisnik> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public AccountController(IConfiguration config, UserManager<Korisnik> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _config = config;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] PostKorisnikDto login)
        {
            if (login.Username != null && !string.IsNullOrWhiteSpace(login.Password))
            {
                var user = await _userManager.FindByNameAsync(login.Username);
                if (user != null)
                {
                    bool passwordCheck = await _userManager.CheckPasswordAsync(user, login.Password);
                    if (!passwordCheck)
                    {
                        return BadRequest("Pogresan Password");
                    }

                    var tokenString = GenerateJSONWebToken(user);
                    return Ok(new { tokenName = tokenString });
                }

                return Unauthorized();
            }
            else
            {
                return BadRequest("Morate popuniti sva polja");
            }
        }

        [AllowAnonymous]
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] PostKorisnikDto user)
        {
            var tokenString = "";
            var zaUnos = _mapper.Map<Korisnik>(user);
            //zaUnos.Id = Guid.NewGuid().ToString();
            await _userManager.UpdateSecurityStampAsync(zaUnos);
            var create = await _userManager.CreateAsync(zaUnos, user.Password);
            if (create.Succeeded)
            {
                await _userManager.AddToRoleAsync(zaUnos, user.KorisnickiTip);
                tokenString = GenerateJSONWebToken(zaUnos);
            }

            return Ok(new { tokenName = tokenString });
        }

        //[Authorize(Roles = "Supervizor")]
        //[HttpGet("Test")]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2", "value3" };
        //}

        [HttpGet("{username}")]
        public async Task<IActionResult> Korisnik(string username)
        {
            var korisnik = await _userManager.FindByNameAsync(username);

            if (korisnik != null)
            {
                return Ok(korisnik.Slika);
            }

            return NotFound();
        }

        private string GenerateJSONWebToken(Korisnik userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var role = _userManager.GetRolesAsync(userInfo).GetAwaiter().GetResult().FirstOrDefault();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(new IdentityOptions().ClaimsIdentity.RoleClaimType, role)
                //new Claim("Role", )
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}