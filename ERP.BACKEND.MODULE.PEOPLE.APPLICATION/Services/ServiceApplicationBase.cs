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
    public class ServiceApplicationBase<TEntidade, TEntidadeDTO> : IApplicationBase<TEntidade, TEntidadeDTO> where TEntidade : EntityBase where TEntidadeDTO : BaseDTO
    {
        protected readonly IServiceBase<TEntidade> service;
        protected readonly IMapper iMapper;

        public ServiceApplicationBase(IMapper iMapper, IServiceBase<TEntidade> service) : base()
        {
            this.iMapper = iMapper;
            this.service = service;
        }

        public async Task<TEntidadeDTO> Update(TEntidadeDTO entidade)
        {
           return iMapper.Map<TEntidadeDTO>(await service.Update(iMapper.Map<TEntidade>(entidade)));
        }

        public async Task<bool> Delete(Guid id)
        {
            return await service.Delete(id);
        }

        public async Task<Guid> Add(TEntidadeDTO entidade)
        {
            return await service.Add(iMapper.Map<TEntidade>(entidade));
        }

        public async Task<TEntidadeDTO> GetById(Guid id)
        {
            return iMapper.Map<TEntidadeDTO>(await service.GetById(id));
        }

        public async Task<IEnumerable<TEntidadeDTO>> GetAll()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(await service.SelectAll());
        }
    }
}
