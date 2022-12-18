using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : EntityBase
    {
        Task<TEntity> Add(TEntity entity);
        Task<bool> Delete(Guid id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<IEnumerable<TEntity>> SelectAll();
    }
}
