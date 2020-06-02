using BrainfinityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class GetGrupaZadatakaDto
    {
        public int Id { get; set; }

        //public Takmicenje Takmicenje { get; set; }
        public int TakmicenjeId { get; set; }

        public Razred Razred { get; set; }
        public int RazredId { get; set; }

        //public IEnumerable<Razred> Razredi { get; set; }
        //public IEnumerable<NivoSkole> NivoiSkole { get; set; }
    }
}