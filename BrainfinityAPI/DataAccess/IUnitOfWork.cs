using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.DataAccess.Repository;

namespace BrainfinityAPI.DataAccess
{
    public interface IUnitOfWork
    {
        ITakmicenjeRepository TakmicenjeRepository { get; }
        IGrupaZadatakaRepository GrupaZadatakaRepository { get; }
        INivoSkoleRepository NivoSkoleRepository { get; }
        IRazredRepository RazredRepository { get; }
        IZadatakRepository ZadatakRepository { get; }

        int Save();
    }
}