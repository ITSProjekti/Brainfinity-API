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
        public string Razred { get; set; }
        public string NivoSkole { get; set; }

        public int TakmicenjeId { get; set; }
    }
}