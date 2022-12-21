namespace Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories
{
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity?> GetById(Guid id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
