using PeopleManagement.Domain.Entities;

namespace PeopleManagement.Domain.Interfaces.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetAll();
    }
}
