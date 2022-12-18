using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    public interface IUserApplication : IApplicationBase<User, UserDTO>
    {
        Task<ResponseBase<UserAuthenticateResponse>> Authenticate(UserAuthenticateRequest entity);
    }
}
