namespace PeopleManagement.Application.Mapping
{
    using AutoMapper;
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests.Person;
    using PeopleManagement.Application.DTOs.Requests.User;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Application.DTOs.Response.Person;
    using PeopleManagement.Application.DTOs.Response.User;
    using PeopleManagement.Domain.Entities;

    public class EntityMapping : Profile
    {
        public EntityMapping()
        {
            CreateUserMapping();
            CreatePersonMapping();
        }

        public void CreateUserMapping()
        {
            CreateMap<User, UserDTO>();
            CreateMap<User, UserAuthenticationResponse>();
            CreateMap<User, ResponseBase<UserAuthenticationResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase<UserDTO>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, ResponseBase>();
            CreateMap<User, UserUpdateResponse>();
            CreateMap<User, ResponseBase<UserUpdateResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<User, UserAddResponse>();
            CreateMap<User, ResponseBase<UserAddResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<IEnumerable<User>, ResponseBase<IEnumerable<UserDTO>>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<UserDTO, User>();
            CreateMap<UserDTO, ResponseBase>();
            CreateMap<UserAuthenticationRequest, User>();
            CreateMap<ResponseBase<UserDTO>, UserDTO>();
            CreateMap<UserUpdateRequest, User>();
            CreateMap<UserAddRequest, User>();
        }

        public void CreatePersonMapping()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<Person, ResponseBase<PersonDTO>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<Person, ResponseBase>();
            CreateMap<Person, PersonUpdateResponse>();
            CreateMap<Person, ResponseBase<PersonUpdateResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<Person, PersonAddResponse>();
            CreateMap<Person, ResponseBase<PersonAddResponse>>().ForMember(x => x.Response, map => map.MapFrom(y => y));
            CreateMap<IEnumerable<Person>, ResponseBase<IEnumerable<PersonDTO>>>().ForMember(x => x.Response, map => map.MapFrom(y => y));

            CreateMap<PersonDTO, Person>();
            CreateMap<PersonDTO, ResponseBase>();
            CreateMap<ResponseBase<PersonDTO>, PersonDTO>();
            CreateMap<PersonUpdateRequest, Person>();
            CreateMap<PersonAddRequest, Person>();
        }
    }
}
