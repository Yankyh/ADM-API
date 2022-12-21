namespace Backend.Module.PERSON.APPLICATION.Interfaces
{
    using Backend.Module.PERSON.APPLICATION.DTOs;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Backend.Module.PERSON.DOMAIN.Entities;

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
