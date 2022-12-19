namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Services
{
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;

    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : EntityBase
    {
        protected readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repositorio)
        {
            this.repository = repositorio;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            return await repository.Update(entity);
        }

        public virtual async Task<bool> Delete(Guid id)
        {
           return await repository.Delete(id);
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            return await repository.Add(entity);
        }

        public virtual Task<TEntity?> GetById(Guid id) => repository.GetById(id);
    }
}
