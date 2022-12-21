namespace PeopleManagement.Domain.Interfaces.Services
{
    using PeopleManagement.Domain.Entities;

    public interface IUserService
    {
        Task<User> Authenticate(User entity);
        Task<IEnumerable<User>> GetAll();
    }
}
