namespace Erp.Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests.User;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

    public interface IUserApplication : IApplicationBase<User, UserDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<UserAuthenticateResponse>> Authenticate(UserAuthenticateRequest entity);
        Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request);
    }
}
