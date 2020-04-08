using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Data;
using BrainfinityAPI.DataAccess.Repository;

namespace BrainfinityAPI.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        private ITakmicenjeRepository _takmicenje;

        public ITakmicenjeRepository TakmicenjeRepository
        {
            get
            {
                if (_takmicenje == null)
                {
                    _takmicenje = new TakmicenjeRepository(_context);
                }
                return _takmicenje;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}