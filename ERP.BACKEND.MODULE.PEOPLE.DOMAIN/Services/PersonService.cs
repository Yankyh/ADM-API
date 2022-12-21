namespace Erp.Backend.Module.PERSON.DOMAIN.Services
{
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
    using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IPersonRepository repositorio) : base(repositorio)
        {

        }
    }
}
