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
    public class GrupaZadatakaService : IGrupaZadatakaService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public GrupaZadatakaService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public GetGrupaZadatakaDto GetGrupaZadataka(int grupaId)
        {
            var grupaIzBaze = _uow.GrupaZadatakaRepository.GetGrupaZadataka(grupaId);

            return _mapper.Map<GetGrupaZadatakaDto>(grupaIzBaze);
        }

        public GetSveGrupeZadatakaDto GetSveGrupeZadataka(int takmicenjeId)
        {
            var sveGrupeIzBaze = _uow.GrupaZadatakaRepository.GetSveGrupeZadataka(takmicenjeId);

            IEnumerable<GetGrupaZadatakaDto> sveGrupe = _mapper.Map<IEnumerable<GetGrupaZadatakaDto>>(sveGrupeIzBaze);
            IEnumerable<Razred> razredi = _uow.RazredRepository.GetAllRazreds();

            var liste = new GetSveGrupeZadatakaDto
            {
                SveGrupe = sveGrupe,
                Razredi = PreostaliRazredi(sveGrupe, razredi),
                NivoiSkole = _uow.NivoSkoleRepository.GetAllNivoSkole(),
                NazivTakmicenja = _uow.TakmicenjeRepository.GetTakmicenje(takmicenjeId).Naziv,
                TakmicenjeId = takmicenjeId,
            };

            return liste;
        }

        public IEnumerable<Razred> PreostaliRazredi(IEnumerable<GetGrupaZadatakaDto> sveGrupe, IEnumerable<Razred> sviRazredi)
        {
            var razredi = sviRazredi.ToList();

            foreach (var grupa in sveGrupe)
            {
                razredi.Remove(razredi.SingleOrDefault(r => r.Id == grupa.RazredId));
            }

            return razredi;
        }

        public bool NovaGrupaZadataka(PostGrupaZadatakaDto grupaZadataka)
        {
            var grupaZaUnos = _mapper.Map<GrupaZadataka>(grupaZadataka);
            _uow.GrupaZadatakaRepository.NovaGrupaZadataka(grupaZaUnos);
            _uow.Save();

            return true;
        }

        public bool EditGrupaZadataka(PostGrupaZadatakaDto grupaZadataka, int grupaId)
        {
            var grupaIzBaze = _uow.GrupaZadatakaRepository.GetGrupaZadataka(grupaId);

            if (grupaIzBaze == null)
            {
                return false;
            }

            if (grupaZadataka == null)
            {
                return false;
            }

            var grupa = _mapper.Map(grupaZadataka, grupaIzBaze);
            _uow.GrupaZadatakaRepository.EditGrupaZadataka(grupa);
            _uow.Save();

            return true;
        }

        public bool RemoveGrupaZadataka(int id)
        {
            if (_uow.GrupaZadatakaRepository.GetGrupaZadataka(id) == null)
            {
                return false;
            }

            _uow.GrupaZadatakaRepository.RemoveGrupaZadataka(id);
            _uow.Save();

            return true;
        }
    }
}