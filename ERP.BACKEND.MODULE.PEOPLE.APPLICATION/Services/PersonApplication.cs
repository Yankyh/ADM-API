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
    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
