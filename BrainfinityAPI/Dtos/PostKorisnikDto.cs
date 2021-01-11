using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class PostKorisnikDto
    {
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public byte[] Logo { get; set; }
        public string KorisnickiTip { get; set; }
    }
}