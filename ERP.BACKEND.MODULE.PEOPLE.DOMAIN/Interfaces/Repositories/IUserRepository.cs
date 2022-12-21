namespace PeopleManagement.Domain.Interfaces.Repositories
{
    using PeopleManagement.Domain.Entities;

    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByName(string name);
        Task<User?> GetByEmail(string name);
    }
}
