using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Services
{
    public interface ITakmicenjeService
    {
        TakmicenjeDto GetTakmicenje(int id);

        IEnumerable<TakmicenjeDto> GetTakmicenjes();

        bool PostTakmicenje(TakmicenjeDto takmicenje);

        bool RemoveTakmicenje(int id);
    }
}