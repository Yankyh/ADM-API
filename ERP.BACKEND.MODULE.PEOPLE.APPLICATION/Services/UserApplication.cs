namespace PeopleManagement.Application.Services
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.DTOs.Response.User;
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

        public async Task<ResponseBase<UserAuthenticationResponse>> Authentication(UserAuthenticationRequest entity)
        {
            return iMapper.Map<ResponseBase<UserAuthenticationResponse>>(await _service.Authentication(iMapper.Map<User>(entity)));
        }

        public async Task<ResponseBase<IEnumerable<UserDTO>>> GetAll(UserGetAllRequest request)
        {
            var entities = await _service.GetAll();

            entities = Filter(request, entities);

            return iMapper.Map<ResponseBase<IEnumerable<UserDTO>>>(entities);
        }

        public async Task<ResponseBase<UserUpdateResponse>> Update(UserUpdateRequest entity)
        {
            return iMapper.Map<ResponseBase<UserUpdateResponse>>(await service.Update(iMapper.Map<User>(entity)));
        }
    }
}
