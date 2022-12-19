namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Requests;
    using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs.Response;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public interface IApplicationBase<TEntity, TEntityDTO, TRequest>
        where TEntity : EntityBase
        where TEntityDTO : BaseDTO
        where TRequest : DefaultFilterRequest
    {
        Task<ResponseBase<TEntityDTO>> Add(TEntityDTO entity);
        Task<ResponseBase> Delete(Guid id);
        Task<ResponseBase<TEntityDTO>> Update(TEntityDTO entity);
        Task<ResponseBase<TEntityDTO>> GetById(Guid id);
    }
}
