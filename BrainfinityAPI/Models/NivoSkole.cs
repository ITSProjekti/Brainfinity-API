using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public class NivoSkole
    {
        public int Id { get; set; }
        public string NivoSkoleNaziv { get; set; }
        //public virtual ICollection<Razred> Razredi { get; set; }
    }
}