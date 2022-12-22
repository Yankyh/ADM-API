namespace PeopleManagement.Domain.Services
{
    using PeopleManagement.Domain.Entities;
    using PeopleManagement.Domain.Interfaces.Repositories;
    using PeopleManagement.Domain.Interfaces.Services;

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
