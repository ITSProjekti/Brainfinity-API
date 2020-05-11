﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Models
{
    public class GrupaZadataka
    {
        public int Id { get; set; }
        public string Razred { get; set; }
        public string NivoSkole { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public int TakmicenjeId { get; set; }
    }
}