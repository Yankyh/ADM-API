namespace Backend.Module.PERSON.DOMAIN.Interfaces.Services
{
    using Backend.Module.PERSON.DOMAIN.Entities;

    public interface IUserService
    {
        Task<User> Authenticate(User entity);
        Task<IEnumerable<User>> GetAll();
    }
}
