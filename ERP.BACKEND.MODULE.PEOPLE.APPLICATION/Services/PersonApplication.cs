namespace PeopleManagement.Application.Services
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests.Person;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Services;

    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {

        }
    }
}
