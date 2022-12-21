namespace PeopleManagement.Domain.Interfaces.Services
{
    using PeopleManagement.Domain.Entities;

    public interface IServiceBase<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity?> GetById(Guid id);
    }
}
