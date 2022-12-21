namespace PeopleManagement.Application.Interfaces
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.DTOs.Response.User;
    using PeopleManagement.Domain.Entities;

    public interface IUserApplication : IApplicationBase<User, UserDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<UserAuthenticationResponse>> Authentication(UserAuthenticationRequest entity);
        Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request);
        Task<ResponseBase<UserUpdateResponse>> Update(UserUpdateRequest entity);
    }
}
