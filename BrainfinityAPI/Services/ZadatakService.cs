using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.DataAccess;
using AutoMapper;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Services
{
    public class ZadatakService : IZadatakService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ZadatakService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public bool DeleteZadatak(int zadatakId)
        {
            if (_uow.ZadatakRepository.GetZadatak(zadatakId) == null)
            {
                return false;
            }

            _uow.ZadatakRepository.DeleteZadatak(zadatakId);
            _uow.Save();

            return true;
        }

        public bool EditZadatak(PostZadatakDto zadatak, int zadatakId)
        {
            var zadatakIzBaze = _uow.ZadatakRepository.GetZadatak(zadatakId);

            if (zadatakIzBaze == null)
            {
                return false;
            }

            var zadatakZaIzmenu = _mapper.Map(zadatak, zadatakIzBaze);
            _uow.ZadatakRepository.EditZadatak(zadatakZaIzmenu);
            _uow.Save();

            return true;
        }

        public IEnumerable<GetZadatakDto> GetSviZadaci(int grupaId)
        {
            var zadaciIzBaze = _uow.ZadatakRepository.GetSviZadaci(grupaId);
            return _mapper.Map<IEnumerable<GetZadatakDto>>(zadaciIzBaze);
        }

        public GetZadatakDto GetZadatak(int zadatakId)
        {
            var zadatakIzBaze = _uow.ZadatakRepository.GetZadatak(zadatakId);
            return _mapper.Map<GetZadatakDto>(zadatakIzBaze);
        }

        public bool PostZadatak(PostZadatakDto zadatak)
        {
            var zadatakZaUnos = _mapper.Map<Zadatak>(zadatak);
            _uow.ZadatakRepository.PostZadatak(zadatakZaUnos);
            _uow.Save();

            return true;
        }
    }
}