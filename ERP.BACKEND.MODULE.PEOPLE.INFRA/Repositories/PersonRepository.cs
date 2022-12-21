using Erp.Backend.Module.PERSON.DOMAIN.Entities;
using Erp.Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
using Erp.Backend.Module.PERSON.INFRA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Backend.Module.PERSON.INFRA.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
