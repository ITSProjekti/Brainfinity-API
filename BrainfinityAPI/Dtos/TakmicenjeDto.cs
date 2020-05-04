using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class TakmicenjeDto
    {
        public int Id { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public DateTime DatumOd { get; set; }

        [Required]
        public DateTime DatumDo { get; set; }

        public string Slika { get; set; }

        [Required]
        public int Status { get; set; }
    }
}