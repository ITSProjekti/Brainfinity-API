using BrainfinityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class GetZadatakDto
    {
        public int Id { get; set; }
        public string ZadatakNaziv { get; set; }
        public int Bodovi { get; set; }

        public GrupaZadataka GrupaZadataka { get; set; }
        public int GrupaZadatakaId { get; set; }
    }
}