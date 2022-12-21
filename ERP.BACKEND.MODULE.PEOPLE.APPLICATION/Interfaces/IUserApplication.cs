namespace Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Backend.Module.PERSON.APPLICATION.DTOs;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests.User;
    using Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Backend.Module.PERSON.DOMAIN.Entities;

    public interface IUserApplication : IApplicationBase<User, UserDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<UserAuthenticateResponse>> Authenticate(UserAuthenticateRequest entity);
        Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request);
    }
}
