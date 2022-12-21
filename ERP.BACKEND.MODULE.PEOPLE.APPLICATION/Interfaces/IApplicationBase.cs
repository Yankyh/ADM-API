namespace Erp.Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Erp.Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;

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
