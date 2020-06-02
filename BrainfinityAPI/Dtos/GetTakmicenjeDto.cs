using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Dtos
{
    public class GetTakmicenjeDto
    {
        public int Id { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public DateTime DatumOd { get; set; }

        [Required]
        public DateTime DatumDo { get; set; }

        public string Slika { get; set; }

        public int StatusId { get; set; }
    }
}