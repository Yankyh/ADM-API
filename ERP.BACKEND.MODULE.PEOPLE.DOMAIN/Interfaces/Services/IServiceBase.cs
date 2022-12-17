using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services
{
    public interface IServiceBase<TEntidade> where TEntidade : EntityBase
    {
        Task<Guid> Add(TEntidade entidade);
        Task<bool> Delete(Guid id);
        Task<TEntidade> Update(TEntidade entidade);
        Task<TEntidade> GetById(Guid id);
        Task<IEnumerable<TEntidade>> SelectAll();
    }
}
