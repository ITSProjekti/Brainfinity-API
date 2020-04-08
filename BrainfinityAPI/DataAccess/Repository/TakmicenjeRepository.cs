using BrainfinityAPI.Data;
using BrainfinityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.DataAccess.Repository
{
    public class TakmicenjeRepository : ITakmicenjeRepository
    {
        private readonly ApplicationDbContext _context;

        public TakmicenjeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Takmicenje GetTakmicenje(int id)
        {
            return _context.Takmicenjes.Where(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Takmicenje> GetTakmicenjes()
        {
            return _context.Takmicenjes.ToList();
        }

        //public void PatchTakmicenje(int id)
        //{
        //}

        public void PostTakmicenje(Takmicenje takmicenje)
        {
            _context.Takmicenjes.Add(takmicenje);
        }

        //public void PutTakmicenje(int id)
        //{
        //    _context.Takmicenjes.Update(GetTakmicenje(id));
        //}

        public void RemoveTakmicenje(int id)
        {
            _context.Takmicenjes.Remove(GetTakmicenje(id));
        }
    }
}