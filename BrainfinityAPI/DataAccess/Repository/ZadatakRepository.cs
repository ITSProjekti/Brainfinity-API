using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;
using BrainfinityAPI.Data;

namespace BrainfinityAPI.DataAccess.Repository
{
    public class ZadatakRepository : IZadatakRepository
    {
        private readonly ApplicationDbContext _context;

        public ZadatakRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void DeleteZadatak(int zadatakId)
            => _context.Zadataks.Remove(GetZadatak(zadatakId));

        public void EditZadatak(Zadatak zadatak)
        {
        }

        public IEnumerable<Zadatak> GetSviZadaci(int grupaId)
            => _context.Zadataks.Where(m => m.GrupaZadatakaId == grupaId).ToList();

        public Zadatak GetZadatak(int zadatakId)
            => _context.Zadataks.SingleOrDefault(m => m.Id == zadatakId);

        public void PostZadatak(Zadatak zadatak)
            => _context.Zadataks.Add(zadatak);
    }
}