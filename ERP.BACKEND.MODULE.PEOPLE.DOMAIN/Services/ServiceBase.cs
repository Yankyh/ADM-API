using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Services
{
    public class ServiceBase<TEntidade> : IServiceBase<TEntidade> where TEntidade : EntityBase
    {
        protected readonly IRepositoryBase<TEntidade> repository;

        public ServiceBase(IRepositoryBase<TEntidade> repositorio)
        {
            this.repository = repositorio;
        }

        public async Task<TEntidade> Update(TEntidade entidade)
        {
            return await repository.Update(entidade);
        }

        public async Task<bool> Delete(Guid id)
        {
           return await repository.Delete(id);
        }

        public async Task<Guid> Add(TEntidade entidade)
        {
            return await repository.Add(entidade);
        }

        public Task<TEntidade> GetById(Guid id)
        {
            return repository.GetById(id);
        }

        public Task<IEnumerable<TEntidade>> SelectAll()
        {
            return repository.GetAll();
        }
    }
}
