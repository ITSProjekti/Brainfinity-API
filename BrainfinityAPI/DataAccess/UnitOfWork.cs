using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        private IGrupaZadatakaRepository _grupaZadataka;

        public IGrupaZadatakaRepository GrupaZadatakaRepository
        {
            get
            {
                if (_grupaZadataka == null)
                {
                    _grupaZadataka = new GrupaZadatakaRepository(_context);
                }
                return _grupaZadataka;
            }
        }

        private INivoSkoleRepository _nivoSkole;

        public INivoSkoleRepository NivoSkoleRepository
        {
            get
            {
                if (_nivoSkole == null)
                {
                    _nivoSkole = new NivoSkoleRepository(_context);
                }
                return _nivoSkole;
            }
        }

        private IRazredRepository _razred;

        public IRazredRepository RazredRepository
        {
            get
            {
                if (_razred == null)
                {
                    _razred = new RazredRepository(_context);
                }
                return _razred;
            }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}