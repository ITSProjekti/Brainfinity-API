using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BrainfinityAPI.Dtos;
using BrainfinityAPI.Models;

namespace BrainfinityAPI.Maps
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Takmicenje, GetTakmicenjeDto>();
            CreateMap<GetTakmicenjeDto, Takmicenje>();
            CreateMap<PostTakmicenjeDto, Takmicenje>();
            CreateMap<PostTakmicenjeDto, Takmicenje>();

            CreateMap<GrupaZadataka, GetGrupaZadatakaDto>();
            CreateMap<GetGrupaZadatakaDto, GrupaZadataka>();
            CreateMap<PostGrupaZadatakaDto, GrupaZadataka>();
        }
    }
}