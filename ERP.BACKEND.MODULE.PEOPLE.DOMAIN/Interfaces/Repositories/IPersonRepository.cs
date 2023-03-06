namespace PeopleManagement.Domain.Interfaces.Repositories
{
    using PeopleManagement.Domain.Entities;

    public interface IPersonRepository : IRepositoryBase<Person>
    {
        Task<Person?> GetByName(string name);
        Task<Person?> GetByCpfCnpj(string name);
    }
}
