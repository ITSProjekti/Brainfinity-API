using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public class Razred
    {
        public int Id { get; set; }
        public string RazredNaziv { get; set; }
        public int NivoSkoleId { get; set; }
        public virtual NivoSkole NivoSkole { get; set; }
    }
}