using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Dtos;

namespace BrainfinityAPI.Services
{
    public interface ITakmicenjeService
    {
        GetTakmicenjeDto GetTakmicenje(int id);

        IEnumerable<GetTakmicenjeDto> GetTakmicenjes();

        bool PostTakmicenje(GetTakmicenjeDto takmicenje);

        bool RemoveTakmicenje(int id);

        bool PutUpdateTakmicenje(UpdateTakmicenjeDto takmicenje, int id);
    }
}