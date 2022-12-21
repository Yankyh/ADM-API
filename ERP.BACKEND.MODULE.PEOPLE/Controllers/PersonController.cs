namespace PeopleManagement.Api
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.Interfaces;
    using PeopleManagement.Domain.Entities;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]

    public class PersonController : BaseController<Person, PersonDTO>
    {
        public PersonController(IPersonApplication app) : base(app)
        { }
    }
}
