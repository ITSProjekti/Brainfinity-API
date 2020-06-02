using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class PostTakmicenjeDto
    {
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