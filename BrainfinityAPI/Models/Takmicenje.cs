using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    //public enum Status
    //{
    //    Arhivirano,
    //    Aktivno,
    //    Nastupajuce
    //}

    public class Takmicenje
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Naziv { get; set; }

        [Required]
        public DateTime DatumOd { get; set; }

        [Required]
        public DateTime DatumDo { get; set; }

        public string Slika { get; set; }

        public virtual Status Status { get; set; }

        public int StatusId { get; set; }
    }
}