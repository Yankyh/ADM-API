namespace Erp.Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

    public interface IPersonApplication : IApplicationBase<Person, PersonDTO, DefaultFilterRequest>
    {
    }
}
