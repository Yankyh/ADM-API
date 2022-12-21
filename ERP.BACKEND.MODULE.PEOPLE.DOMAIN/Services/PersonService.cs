namespace PeopleManagement.Domain.Services
{
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using PeopleManagement.Domain.Interfaces.Services;

    public class PersonService : ServiceBase<Person>, IPersonService
    {
        public PersonService(IPersonRepository repositorio) : base(repositorio)
        {

        }
    }
}
