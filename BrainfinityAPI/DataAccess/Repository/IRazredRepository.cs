using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.DataAccess.Repository
{
    public interface IRazredRepository
    {
        IEnumerable<Razred> GetAllRazreds();

        IEnumerable<Razred> GetPreostaliRazredi(int razredId);

        Razred GetRazred(int razredId);
    }
}