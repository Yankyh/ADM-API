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
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<User?> GetByName(string user) => await appDbContext.Set<User>().FirstOrDefaultAsync(x => x.Name.Equals(user));
    }
}
