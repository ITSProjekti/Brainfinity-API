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

        public TakmicenjeDto GetTakmicenje(int id)
        {
            return uow.TakmicenjeRepository.GetTakmicenje(id);
        }

        public IEnumerable<TakmicenjeDto> GetTakmicenjes()
        {
            return uow.TakmicenjeRepository.GetTakmicenjes();
        }

        public bool PostTakmicenje(TakmicenjeDto takmicenje)
        {
            if (takmicenje.DatumOd.CompareTo(DateTime.Now) > 0 && takmicenje.DatumOd.CompareTo(takmicenje.DatumDo) < 0)
            {
                uow.TakmicenjeRepository.PostTakmicenje(takmicenje);
                uow.Save();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveTakmicenje(int id)
        {
            var takmicenjeZaBrisanje = uow.TakmicenjeRepository.GetTakmicenje(id);
            if (takmicenjeZaBrisanje == null)
            {
                //promeniti da baca custom exception koji ce se hvatati u kontroleru
                return false;
            }

            uow.TakmicenjeRepository.RemoveTakmicenje(id);
            uow.Save();

            return true;
        }
    }
}