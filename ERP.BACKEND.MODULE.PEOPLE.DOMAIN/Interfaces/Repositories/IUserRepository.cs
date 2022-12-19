namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories
{
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User?> GetByName(string name);
    }
}
