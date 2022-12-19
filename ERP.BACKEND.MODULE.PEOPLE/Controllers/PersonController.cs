namespace ERP.BACKEND.MODULE.PERSON.Controllers
{
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : BaseController<Person, PersonDTO>
    {
        public PersonController(IPersonApplication app) : base(app)
        { }
    }
}
