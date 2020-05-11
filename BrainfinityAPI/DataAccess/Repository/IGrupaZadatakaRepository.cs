using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public interface IGrupaZadatakaRepository
    {
        IEnumerable<GrupaZadataka> GetSveGrupeZadataka(int takmicenjeId);

        GrupaZadataka GetGrupaZadataka(int grupaId);

        void NovaGrupaZadataka(GrupaZadataka grupaZadataka);
    }
}