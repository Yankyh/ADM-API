namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Mapping
{
    using AutoMapper;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.User;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

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
