using AutoMapper;
using ERP.BACKEND.MODULE.PEOPLE.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.APPLICATION.Mapping
{
    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateMap<People, PeopleDTO>();
            CreateMap<PeopleDTO, People>();
        }
    }
}
