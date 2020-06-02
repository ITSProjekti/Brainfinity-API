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

        bool PostTakmicenje(PostTakmicenjeDto takmicenje);

        bool RemoveTakmicenje(int id);

        bool PutUpdateTakmicenje(PostTakmicenjeDto takmicenje, int id);
    }
}