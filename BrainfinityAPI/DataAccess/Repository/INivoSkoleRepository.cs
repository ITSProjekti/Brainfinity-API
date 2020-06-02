using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public interface INivoSkoleRepository
    {
        IEnumerable<NivoSkole> GetAllNivoSkole();

        NivoSkole GetNivoSkole(int id);
    }
}