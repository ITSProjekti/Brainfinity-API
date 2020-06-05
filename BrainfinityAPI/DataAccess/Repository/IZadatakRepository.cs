using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public interface IZadatakRepository
    {
        IEnumerable<Zadatak> GetSviZadaci(int grupaId);

        Zadatak GetZadatak(int zadatakId);

        void PostZadatak(Zadatak zadatak);

        void DeleteZadatak(int zadatakId);
    }
}