using PeopleManagement.Domain.Entities;
using PeopleManagement.Domain.Interfaces.Repositories;
using PeopleManagement.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Infra.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext) { }

        public async Task<User?> GetByName(string user) => await appDbContext.Set<User>().FirstOrDefaultAsync(x => x.Name.Equals(user));
    }
}
