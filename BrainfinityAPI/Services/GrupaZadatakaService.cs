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

        public IEnumerable<GetGrupaZadatakaDto> GetSveGrupeZadataka(int takmicenjeId)
        {
            var sveGrupeIzBaze = _uow.GrupaZadatakaRepository.GetSveGrupeZadataka(takmicenjeId);
            return _mapper.Map<IEnumerable<GetGrupaZadatakaDto>>(sveGrupeIzBaze);
        }

        public bool NovaGrupaZadataka(UpdateGrupaZadatakaDto grupaZadataka)
        {
            var grupaZaUnos = _mapper.Map<GrupaZadataka>(grupaZadataka);
            _uow.GrupaZadatakaRepository.NovaGrupaZadataka(grupaZaUnos);
            _uow.Save();

            return true;
        }
    }
}