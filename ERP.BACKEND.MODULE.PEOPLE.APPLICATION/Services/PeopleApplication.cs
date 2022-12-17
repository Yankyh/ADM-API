using AutoMapper;
using ERP.BACKEND.MODULE.PEOPLE.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PEOPLE.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.APPLICATION.Services
{
    public class PeopleApplication : ServiceApplicationBase<People, PeopleDTO>, IPeopleApplication
    {
        public PeopleApplication(IMapper iMapper, IPeopleService service) : base(iMapper, (IServiceBase<People>)service)
        {

        }
    }
}
