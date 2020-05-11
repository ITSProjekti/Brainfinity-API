using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;

namespace BrainfinityAPI.Services
{
    public interface IGrupaZadatakaService
    {
        GetGrupaZadatakaDto GetGrupaZadataka(int grupaId);

        IEnumerable<GetGrupaZadatakaDto> GetSveGrupeZadataka(int takmicenjeId);

        bool NovaGrupaZadataka(UpdateGrupaZadatakaDto grupaZadataka);
    }
}