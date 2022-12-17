using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace ERP.BACKEND.MODULE.PERSON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : BaseController<Person, PersonDTO>
    {
        public PersonController(IPersonApplication app) : base(app)
        { }
    }
}
