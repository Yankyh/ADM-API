namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Services
{
    using AutoMapper;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.Person;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;

    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
