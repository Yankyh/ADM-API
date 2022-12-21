namespace Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Backend.Module.PERSON.APPLICATION.DTOs;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Backend.Module.PERSON.DOMAIN.Entities;

    public interface IPersonApplication : IApplicationBase<Person, PersonDTO, DefaultFilterRequest>
    {
    }
}
