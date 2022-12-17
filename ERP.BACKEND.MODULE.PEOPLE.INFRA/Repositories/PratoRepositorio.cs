using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PERSON.INFRA.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.INFRA.Repositories
{
    public class PratoRepositorio : RepositoryBase<Person>, IPratoRepositorio
    {
        public PratoRepositorio(AppDbContext appDbContext)
            : base(appDbContext)
        {
        }
    }
}
