namespace Erp.Backend.Module.PERSON.APPLICATION.Services
{
    using AutoMapper;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests.Person;
    using Erp.Backend.Module.PERSON.APPLICATION.Interfaces;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
