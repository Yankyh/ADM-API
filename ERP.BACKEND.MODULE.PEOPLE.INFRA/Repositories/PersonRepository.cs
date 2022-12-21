using Backend.Module.PERSON.DOMAIN.Entities;
using Backend.Module.PERSON.DOMAIN.Interfaces.Repositories;
using Backend.Module.PERSON.INFRA.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Module.PERSON.INFRA.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
