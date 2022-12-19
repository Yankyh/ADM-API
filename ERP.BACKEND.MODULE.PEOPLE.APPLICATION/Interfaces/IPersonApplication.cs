namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public interface IPersonApplication : IApplicationBase<Person, PersonDTO, DefaultFilterRequest>
    {
    }
}
