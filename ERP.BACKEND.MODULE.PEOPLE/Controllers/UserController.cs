using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ERP.BACKEND.MODULE.PERSON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : BaseController<User, UserDTO>
    {
        public UserController(IUserApplication app) : base(app)
        { }
    }
}
