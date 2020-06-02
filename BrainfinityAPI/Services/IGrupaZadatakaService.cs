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

        GetSveGrupeZadatakaDto GetSveGrupeZadataka(int takmicenjeId);

        bool NovaGrupaZadataka(PostGrupaZadatakaDto grupaZadataka);

        bool EditGrupaZadataka(PostGrupaZadatakaDto grupaZadataka, int grupaId);
    }
}