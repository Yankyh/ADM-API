using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;

namespace ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntidade> where TEntidade : EntityBase
    {
        Task<Guid> Add(TEntidade entidade);
        Task<bool> Delete(Guid id);
        Task<TEntidade> Update(TEntidade entidade);
        Task<TEntidade> GetById(Guid id);
        Task<IEnumerable<TEntidade>> GetAll();
    }
}
