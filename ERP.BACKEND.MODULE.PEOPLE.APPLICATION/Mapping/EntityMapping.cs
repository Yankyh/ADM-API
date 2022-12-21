namespace Erp.Backend.Module.PERSON.APPLICATION.Mapping
{
    using AutoMapper;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests.User;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();
         //   CreateMap<PersonDTO, ResponseBase<UserAuthenticateResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<UserAuthenticateRequest, User>();
            CreateMap<User, UserAuthenticateResponse>();
            CreateMap<User, ResponseBase<UserAuthenticateResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase<UserDTO>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase>();
            CreateMap<ResponseBase<UserDTO>, UserDTO>();

            CreateMap<IEnumerable<User>, ResponseBase<IEnumerable<UserDTO>>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<UserDTO, ResponseBase>();
        }
    }
}
