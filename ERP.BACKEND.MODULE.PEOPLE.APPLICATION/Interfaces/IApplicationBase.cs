using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    public interface IApplicationBase<TEntity, TEntityDTO>
        where TEntity : EntityBase
        where TEntityDTO : BaseDTO
    {
        Task<Guid> Add(TEntityDTO entity);
        Task<bool> Delete(Guid id);
        Task<TEntityDTO> Update(TEntityDTO entity);
        Task<TEntityDTO> GetById(Guid id);
        Task<IEnumerable<TEntityDTO>> GetAll();
    }
}
