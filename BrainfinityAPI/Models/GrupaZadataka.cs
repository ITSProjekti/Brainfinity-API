using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public class GrupaZadataka
    {
        public int Id { get; set; }

        public int TakmicenjeId { get; set; }
        public virtual Takmicenje Takmicenje { get; set; }

        public int RazredId { get; set; }
        public virtual Razred Razred { get; set; }
    }
}