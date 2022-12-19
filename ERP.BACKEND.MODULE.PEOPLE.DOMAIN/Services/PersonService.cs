namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Services
{
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IPersonRepository repositorio) : base(repositorio)
        {

        }
    }
}
