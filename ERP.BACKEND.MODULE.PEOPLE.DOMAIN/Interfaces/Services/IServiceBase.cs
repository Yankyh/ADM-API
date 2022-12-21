namespace Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Services
{
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

    public interface IServiceBase<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity?> GetById(Guid id);
    }
}
