namespace Backend.Module.PERSON.DOMAIN.Interfaces.Repositories
{
    using Backend.Module.PERSON.DOMAIN.Entities;

    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByName(string name);
    }
}
