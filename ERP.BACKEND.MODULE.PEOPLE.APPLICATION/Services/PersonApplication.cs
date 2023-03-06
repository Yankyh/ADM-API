namespace PeopleManagement.Application.Services
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests.Person;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Services;
    using PeopleManagement.Application.DTOs.Response.Person;

    public class PersonApplication : ServiceApplicationBase<Person, PersonDTO, PersonGetAllRequest>, IPersonApplication
    {
        IPersonService _service;
        public PersonApplication(IMapper iMapper, IPersonService service) : base(iMapper, (IServiceBase<Person>)service)
        {
            this._service = service;
        }

        public async Task<ResponseBase<IEnumerable<PersonDTO>>> GetAll(PersonGetAllRequest request)
        {
            var entities = await _service.GetAll();

            entities = Filter(request, entities);

            return iMapper.Map<ResponseBase<IEnumerable<PersonDTO>>>(entities);
        }

        public async Task<ResponseBase<PersonUpdateResponse>> Update(PersonUpdateRequest entity)
        {
            return iMapper.Map<ResponseBase<PersonUpdateResponse>>(await service.Update(iMapper.Map<Person>(entity)));
        }

        public async Task<ResponseBase<PersonAddResponse>> Add(PersonAddRequest entity)
        {
            return iMapper.Map<ResponseBase<PersonAddResponse>>(await service.Add(iMapper.Map<Person>(entity)));
        }
    }
}
