namespace PeopleManagement.Application.Interfaces
{
    using PeopleManagement.Application.DTOs;
    using PeopleManagement.Application.DTOs.Requests;
    using PeopleManagement.Application.DTOs.Response;
    using PeopleManagement.Domain.Entities;

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
