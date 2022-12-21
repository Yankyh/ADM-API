using Erp.Backend.Module.PERSON.DOMAIN.Entities;
using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
using Erp.Backend.Module.PERSON.INFRA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Backend.Module.PERSON.INFRA.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<User?> GetByName(string user) => await appDbContext.Set<User>().FirstOrDefaultAsync(x => x.Name.Equals(user));
    }
}
