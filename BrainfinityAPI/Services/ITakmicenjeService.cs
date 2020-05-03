using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Services
{
    public interface ITakmicenjeService
    {
        Takmicenje GetTakmicenje(int id);

        IEnumerable<Takmicenje> GetTakmicenjes();

        bool PostTakmicenje(Takmicenje takmicenje);
    }
}