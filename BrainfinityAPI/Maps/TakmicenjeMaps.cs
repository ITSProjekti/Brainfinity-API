using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Maps
{
    public class TakmicenjeMaps : Profile
    {
        public TakmicenjeMaps()
        {
            CreateMap<Takmicenje, GetTakmicenjeDto>();
            CreateMap<GetTakmicenjeDto, Takmicenje>();
            CreateMap<UpdateTakmicenjeDto, Takmicenje>();
        }
    }
}