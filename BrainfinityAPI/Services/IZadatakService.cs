using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrainfinityAPI.Services
{
    public interface IZadatakService
    {
        IEnumerable<GetZadatakDto> GetSviZadaci(int grupaId);

        GetZadatakDto GetZadatak(int zadatakId);

        bool PostZadatak(PostZadatakDto zadatak);

        bool DeleteZadatak(int zadatakId);

        bool EditZadatak(PostZadatakDto zadatak, int zadatakId);
    }
}