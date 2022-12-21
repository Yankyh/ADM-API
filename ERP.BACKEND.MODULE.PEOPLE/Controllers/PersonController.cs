namespace Erp.Backend.Module.PERSON.Controllers
{
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.Interfaces;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : BaseController<Person, PersonDTO>
    {
        public PersonController(IPersonApplication app) : base(app)
        { }
    }
}
