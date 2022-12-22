namespace PeopleManagement.Application.Mapping
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.DTOs.Response.User;
    using PeopleManagement.Domain.Entities;

    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<PersonDTO, Person>();
         //   CreateMap<PersonDTO, ResponseBase<UserAuthenticationResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<UserAuthenticationRequest, User>();
            CreateMap<User, UserAuthenticationResponse>();
            CreateMap<User, ResponseBase<UserAuthenticationResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase<UserDTO>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase>();
            CreateMap<ResponseBase<UserDTO>, UserDTO>();

            CreateMap<UserUpdateRequest, User>();
            CreateMap<User, UserUpdateResponse>();
            CreateMap<User, ResponseBase<UserUpdateResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<UserAddRequest, User>();
            CreateMap<User, UserAddResponse>();
            CreateMap<User, ResponseBase<UserAddResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<IEnumerable<User>, ResponseBase<IEnumerable<UserDTO>>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<UserDTO, ResponseBase>();
        }
    }
}
