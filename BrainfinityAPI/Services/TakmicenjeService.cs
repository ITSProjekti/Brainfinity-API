using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.DataAccess;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Services
{
    public class TakmicenjeService : ITakmicenjeService
    {
        protected readonly IUnitOfWork uow;

        public TakmicenjeService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public Takmicenje GetTakmicenje(int id)
        {
            return uow.TakmicenjeRepository.GetTakmicenje(id);
        }

        public IEnumerable<Takmicenje> GetTakmicenjes()
        {
            return uow.TakmicenjeRepository.GetTakmicenjes();
        }

        public void PostTakmicenje(Takmicenje takmicenje)
        {
            uow.TakmicenjeRepository.PostTakmicenje(takmicenje);
            uow.Save();
        }
    }
}