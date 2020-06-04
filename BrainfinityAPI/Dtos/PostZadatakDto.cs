using BrainfinityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Dtos
{
    public class PostZadatakDto
    {
        public string ZadatakNaziv { get; set; }
        public int Bodovi { get; set; }
        public int GrupaZadatakaId { get; set; }
    }
}