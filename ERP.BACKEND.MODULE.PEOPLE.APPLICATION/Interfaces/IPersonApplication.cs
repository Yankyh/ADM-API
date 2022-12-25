namespace PeopleManagement.Application.Interfaces
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Application.DTOs.Requests.Person;
    using PeopleManagement.Application.DTOs.Response.Person;

    public interface IPersonApplication : IApplicationBase<Person, PersonDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<IEnumerable<PersonDTO>>> GetAll(PersonGetAllRequest request);
        Task<ResponseBase<PersonUpdateResponse>> Update(PersonUpdateRequest entity);
        Task<ResponseBase<PersonAddResponse>> Add(PersonAddRequest entity);
    }
}
