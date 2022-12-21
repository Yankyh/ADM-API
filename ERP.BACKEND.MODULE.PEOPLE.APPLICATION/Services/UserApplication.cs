namespace PeopleManagement.Application.Services
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Services;

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
