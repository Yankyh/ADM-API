using PeopleManagement.Application.DTOs.Requests.Person;
using PeopleManagement.Application.DTOs.Requests;
using PeopleManagement.Application.DTOs.Response.Person;
using PeopleManagement.Application.DTOs.Response;
using PeopleManagement.Application.DTOs;
using PeopleManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManagement.Application.DTOs.Requests.PersonContact;
using PeopleManagement.Application.DTOs.Response.PersonContact;

namespace PeopleManagement.Application.Interfaces
{
    public interface IPersonContactApplication : IApplicationBase<PersonContact, PersonContactDTO, DefaultFilterRequest>
    {
        Task<ResponseBase<IEnumerable<PersonContactDTO>>> GetAll(PersonContactGetAllRequest request);
        Task<ResponseBase<PersonContactUpdateResponse>> Update(PersonContactUpdateRequest entity);
        Task<ResponseBase<PersonContactAddResponse>> Add(PersonContactAddRequest entity);
    }
}
