using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Data;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public class NivoSkoleRepository : INivoSkoleRepository
    {
        private readonly ApplicationDbContext _context;

        public NivoSkoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<NivoSkole> GetAllNivoSkole() => _context.NivoSkoles.ToList();

        public NivoSkole GetNivoSkole(int id) => _context.NivoSkoles.SingleOrDefault(n => n.Id == id);
    }
}