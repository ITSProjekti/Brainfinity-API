using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrainfinityAPI.DataAccess;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Services
{
    public class TakmicenjeService : ITakmicenjeService
    {
        protected readonly IUnitOfWork uow;
        protected readonly IMapper _mapper;

        public TakmicenjeService(IUnitOfWork uow, IMapper mapper)
        {
            this.uow = uow;
            _mapper = mapper;
        }

        public GetTakmicenjeDto GetTakmicenje(int id)
        {
            var takmicenjeIzBaze = uow.TakmicenjeRepository.GetTakmicenje(id);
            return _mapper.Map<GetTakmicenjeDto>(takmicenjeIzBaze);
            //return uow.TakmicenjeRepository.GetTakmicenje(id);
        }

        public IEnumerable<GetTakmicenjeDto> GetTakmicenjes()
        {
            var svaTakmicenjaIzBaze = uow.TakmicenjeRepository.GetTakmicenjes();
            return _mapper.Map<IEnumerable<GetTakmicenjeDto>>(svaTakmicenjaIzBaze);
            //return uow.TakmicenjeRepository.GetTakmicenjes();
        }

        public bool PostTakmicenje(PostTakmicenjeDto takmicenje)
        {
            if (takmicenje.DatumOd.CompareTo(DateTime.Now) > 0 && takmicenje.DatumOd.CompareTo(takmicenje.DatumDo) < 0)
            {
                var takmicenjeZaUnos = _mapper.Map<Takmicenje>(takmicenje);
                takmicenjeZaUnos.StatusId = 3;
                uow.TakmicenjeRepository.PostTakmicenje(takmicenjeZaUnos);
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

        public bool PutUpdateTakmicenje(PostTakmicenjeDto takmicenje, int id)
        {
            var takmicenjeIzBaze = uow.TakmicenjeRepository.GetTakmicenje(id);
            if (takmicenjeIzBaze == null)
            {
                //takodje promeniti na custom exception
                return false;
            }

            if (takmicenje == null)
            {
                //isto exception
                return false;
            }

            var takmicenjeUpdate = _mapper.Map(takmicenje, takmicenjeIzBaze);
            uow.TakmicenjeRepository.UpdateTakmicenje(takmicenjeUpdate);
            uow.Save();

            return true;
        }
    }
}