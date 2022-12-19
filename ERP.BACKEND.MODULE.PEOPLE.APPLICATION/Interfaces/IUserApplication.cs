namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.User;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public interface IUserApplication : IApplicationBase<User, UserDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<UserAuthenticateResponse>> Authenticate(UserAuthenticateRequest entity);
        Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request);
    }
}
