﻿namespace Backend.Module.PERSON.APPLICATION.Services
{
    using AutoMapper;
    using Backend.Module.PERSON.APPLICATION.DTOs;
    using Backend.Module.PERSON.APPLICATION.DTOs.Requests;
    using Backend.Module.PERSON.APPLICATION.DTOs.Response;
    using Backend.Module.PERSON.APPLICATION.Interfaces;
    using Backend.Module.PERSON.DOMAIN.Entities;
    using Backend.Module.PERSON.DOMAIN.Interfaces.Services;
    using Backend.Module.PERSON.COMMON.Enums;

    public class ServiceApplicationBase<TEntity, TEntityDTO, TRequest> : IApplicationBase<TEntity, TEntityDTO, TRequest> where TEntity : EntityBase where TEntityDTO : BaseDTO where TRequest : DefaultFilterRequest
    {
        protected readonly IServiceBase<TEntity> service;
        protected readonly IMapper iMapper;

        public ServiceApplicationBase(IMapper iMapper, IServiceBase<TEntity> service) : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }

        public async Task<ResponseBase<TEntityDTO>> Update(TEntityDTO entity)
        {
            return iMapper.Map<ResponseBase<TEntityDTO>>(await service.Update(iMapper.Map<TEntity>(entity)));
        }

        public async Task<ResponseBase> Delete(Guid id)
        {
            return new ResponseBase { Sucess = await service.Delete(id) };
        }

        public async Task<ResponseBase<TEntityDTO>> Add(TEntityDTO entity)
        {
            return iMapper.Map<ResponseBase<TEntityDTO>>(await service.Add(iMapper.Map<TEntity>(entity)));
        }

        public async Task<ResponseBase<TEntityDTO>> GetById(Guid id)
        {
            return iMapper.Map<ResponseBase<TEntityDTO>>(await service.GetById(id));
        }

        public IEnumerable<TEntity> Filter(TRequest request, IEnumerable<TEntity> entities)
        {
            entities = OrderBy(request, entities);
            entities = Distinct(request, entities);
            entities = GetNumberOfRegisters(request, entities);

            return entities;
        }

        private IEnumerable<TEntity> OrderBy(TRequest request, IEnumerable<TEntity> entities)
        {
            System.Reflection.PropertyInfo property = typeof(TEntity).GetProperty(request.OrderBy) ?? throw new InvalidDataException("Something wen wrong when ordering!");

            if(request.OrderDirection == OrderDirection.ASC)
            {
                entities = entities.OrderBy(x => property.GetValue(x, null));
            }

            else{
                entities = entities.OrderByDescending(x => property.GetValue(x, null));
            }   

            return entities;
        }

        private IEnumerable<TEntity> Distinct(TRequest request, IEnumerable<TEntity> entities)
        {
            if (request.Distinct)
            {
                return entities.Distinct();
            }
            else
            {
                return entities;
            }
        }

        private IEnumerable<TEntity> GetNumberOfRegisters(TRequest request, IEnumerable<TEntity> entities)
        {
            return entities.Skip(request.MinIndex).Take(request.MaxIndex);
        }

    }
}
