using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Data;
using BrainfinityAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainfinityAPI.DataAccess.Repository
{
    public class GrupaZadatakaRepository : IGrupaZadatakaRepository
    {
        private readonly ApplicationDbContext _context;

        public GrupaZadatakaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public GrupaZadataka GetGrupaZadataka(int grupaId)
        {
            return _context.GrupaZadatakas.SingleOrDefault(g => g.Id == grupaId);
        }

        public IEnumerable<GrupaZadataka> GetSveGrupeZadataka(int takmicenjeId)
        {
            return _context.GrupaZadatakas.Where(g => g.Takmicenje.Id == takmicenjeId).ToList();
        }

        public void NovaGrupaZadataka(GrupaZadataka grupaZadataka)
        {
            _context.GrupaZadatakas.Add(grupaZadataka);
        }
    }
}