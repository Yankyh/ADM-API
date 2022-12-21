namespace Erp.Backend.Module.PERSON.APPLICATION.Services
{
    using AutoMapper;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests.User;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Erp.Backend.Module.PERSON.APPLICATION.Interfaces;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class UserApplication : ServiceApplicationBase<User, UserDTO, DefaultFilterRequest>, IUserApplication
    {
        IUserService _service;
        public UserApplication(IMapper iMapper, IUserService service) : base(iMapper, (IServiceBase<User>)service)
        {
            this._service = service;
        }

        public async Task<ResponseBase<UserAuthenticateResponse>> Authenticate(UserAuthenticateRequest entity)
        {
            return iMapper.Map<ResponseBase<UserAuthenticateResponse>>(await _service.Authenticate(iMapper.Map<User>(entity)));
        }

        public async Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request)
        {
            var entities = await _service.GetAll();

            entities = Filter(request, entities);

            return iMapper.Map<ResponseBase<IEnumerable<UserDTO>>>(entities);
        }
    }
}
