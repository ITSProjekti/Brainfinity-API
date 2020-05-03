using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public enum Status
    {
        Arhivirano,
        Aktivno,
        Nastupajuce
    }

    public class Takmicenje
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public DateTime DatumOd { get; set; }
        public DateTime DatumDo { get; set; }
        public string Slika { get; set; }
        public Status Status { get; set; }
    }
}