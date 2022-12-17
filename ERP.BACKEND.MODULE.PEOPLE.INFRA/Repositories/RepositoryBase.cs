using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PERSON.INFRA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.INFRA.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        protected readonly AppDbContext appDbContext;

        public RepositoryBase(AppDbContext appDbContext)
            : base()
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Guid> Add(TEntity entity)
        {
            await appDbContext.AddAsync(entity);

            await appDbContext.SaveChangesAsync();

            if(entity.Id != Guid.Empty)
            {
                return entity.Id;
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
                var entity = await appDbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);

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

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            var entity = await appDbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            appDbContext.Update(entity);

            await appDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
