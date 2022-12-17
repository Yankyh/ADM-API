using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PEOPLE.INFRA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.INFRA.Repositories
{
    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade> where TEntidade : EntityBase
    {
        protected readonly AppDbContext appDbContext;

        public RepositoryBase(AppDbContext appDbContext)
            : base()
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Guid> Add(TEntidade entidade)
        {
            await appDbContext.AddAsync(entidade);

            await appDbContext.SaveChangesAsync();

            if(entidade.Id != Guid.Empty)
            {
                return entidade.Id;
            }
            else
            {
                return Guid.Empty;
            }      
        }

        public async Task<bool> Delete(Guid id)
        {
            try
            {
                var entity = await appDbContext.Set<TEntidade>().FirstOrDefaultAsync(x => x.Id == id);

                if (entity == null)
                {
                    //Not found
                    return false;
                }

                appDbContext.Remove(entity);

                return await appDbContext.SaveChangesAsync() > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<IEnumerable<TEntidade>> GetAll()
        {
            return await appDbContext.Set<TEntidade>().ToListAsync();
        }

        public async Task<TEntidade> GetById(Guid id)
        {
            var entity = await appDbContext.Set<TEntidade>().FirstOrDefaultAsync(x => x.Id == id);

#pragma warning disable CS8603 // Possible null reference return.
            return entity;
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<TEntidade> Update(TEntidade entidade)
        {
            appDbContext.Update(entidade);

            await appDbContext.SaveChangesAsync();

            return entidade;
        }
    }
}
