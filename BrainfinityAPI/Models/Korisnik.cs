using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public class Korisnik : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public byte[] Slika { get; set; }
        public byte[] Logo { get; set; }
    }
}