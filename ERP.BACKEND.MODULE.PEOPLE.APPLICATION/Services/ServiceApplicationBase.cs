using AutoMapper;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Services
{
    public class ServiceApplicationBase<TEntity, TEntityDTO> : IApplicationBase<TEntity, TEntityDTO> where TEntity : EntityBase where TEntityDTO : BaseDTO
    {
        protected readonly IServiceBase<TEntity> service;
        protected readonly IMapper iMapper;

        public ServiceApplicationBase(IMapper iMapper, IServiceBase<TEntity> service) : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }

        public async Task<TEntityDTO> Update(TEntityDTO entity)
        {
           return iMapper.Map<TEntityDTO>(await service.Update(iMapper.Map<TEntity>(entity)));
        }

        public async Task<bool> Delete(Guid id)
        {
            return await service.Delete(id);
        }

        public async Task<Guid> Add(TEntityDTO entity)
        {
            return await service.Add(iMapper.Map<TEntity>(entity));
        }

        public async Task<TEntityDTO> GetById(Guid id)
        {
            return iMapper.Map<TEntityDTO>(await service.GetById(id));
        }

        public async Task<IEnumerable<TEntityDTO>> GetAll()
        {
            return iMapper.Map<IEnumerable<TEntityDTO>>(await service.SelectAll());
        }
    }
}
