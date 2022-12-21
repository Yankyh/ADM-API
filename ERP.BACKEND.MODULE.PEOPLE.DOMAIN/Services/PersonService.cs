namespace Backend.Module.PERSON.DOMAIN.Services
{
    using Backend.Module.PERSON.DOMAIN.Entities;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Services;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IPersonRepository repositorio) : base(repositorio)
        {

        }
    }
}
