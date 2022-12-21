namespace Backend.Module.PERSON.APPLICATION.Services
{
    using AutoMapper;
    using Backend.Module.PERSON.APPLICATION.DTOs;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests.Person;
    using Backend.Module.PERSON.APPLICATION.Interfaces;
    using Backend.Module.PERSON.DOMAIN.Entities;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
