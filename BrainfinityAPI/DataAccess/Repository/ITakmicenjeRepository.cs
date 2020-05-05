using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public interface ITakmicenjeRepository
    {
        Takmicenje GetTakmicenje(int id);

        IEnumerable<Takmicenje> GetTakmicenjes();

        void RemoveTakmicenje(int id);

        void PostTakmicenje(Takmicenje takmicenje);

        void UpdateTakmicenje(Takmicenje takmicenje);

        //void PutTakmicenje(int id);

        //void PatchTakmicenje(int id);
    }
}