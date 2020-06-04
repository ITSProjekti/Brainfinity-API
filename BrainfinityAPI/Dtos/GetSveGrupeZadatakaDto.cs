using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Dtos
{
    public class GetSveGrupeZadatakaDto
    {
        public IEnumerable<GetGrupaZadatakaDto> SveGrupe { get; set; }
        public IEnumerable<Razred> Razredi { get; set; }
        public IEnumerable<NivoSkole> NivoiSkole { get; set; }

        //public IEnumerable<Zadatak> Zadaci { get; set; }
        public string NazivTakmicenja { get; set; }

        public int TakmicenjeId { get; set; }
    }
}