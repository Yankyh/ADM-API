using AutoMapper;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.Person;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Services
{
    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
