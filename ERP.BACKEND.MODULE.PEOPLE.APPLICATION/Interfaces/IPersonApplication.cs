namespace PeopleManagement.Application.Interfaces
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Domain.Entities;

    public interface IPersonApplication : IApplicationBase<Person, PersonDTO, DefaultFilterRequest>
    {
    }
}
