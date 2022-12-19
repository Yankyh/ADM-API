namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services
{
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public interface IUserService
    {
        Task<User> Authenticate(User entity);
        Task<IEnumerable<User>> GetAll();
    }
}
