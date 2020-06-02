using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;
using BrainfinityAPI.Data;

namespace BrainfinityAPI.DataAccess.Repository
{
    public class RazredRepository : IRazredRepository
    {
        private readonly ApplicationDbContext _context;

        public RazredRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Razred> GetAllRazreds() => _context.Razreds.ToList();

        public IEnumerable<Razred> GetPreostaliRazredi(int razredId) => GetAllRazreds().Where(r => r.Id != razredId);

        public Razred GetRazred(int razredId) => _context.Razreds.SingleOrDefault(r => r.Id == razredId);
    }
}