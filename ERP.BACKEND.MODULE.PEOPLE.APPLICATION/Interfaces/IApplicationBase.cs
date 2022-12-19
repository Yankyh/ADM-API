using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests.User;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    public interface IApplicationBase<TEntity, TEntityDTO, TRequest>
        where TEntity : EntityBase
        where TEntityDTO : BaseDTO
        where TRequest : DefaultFilterRequest
    {
        Task<ResponseBase<TEntityDTO>> Add(TEntityDTO entity);
        Task<ResponseBase> Delete(Guid id);
        Task<ResponseBase<TEntityDTO>> Update(TEntityDTO entity);
        Task<ResponseBase<TEntityDTO>> GetById(Guid id);
      //  Task<ResponseBase<IEnumerable<TEntityDTO>>> GetAll(UserGetAllRequest request);
    }
}
