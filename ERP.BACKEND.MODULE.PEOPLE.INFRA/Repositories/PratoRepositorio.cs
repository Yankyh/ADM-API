using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PEOPLE.INFRA.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.INFRA.Repositories
{
    public class PratoRepositorio : RepositoryBase<People>, IPratoRepositorio
    {
        public PratoRepositorio(AppDbContext appDbContext)
            : base(appDbContext)
        {
        }
    }
}
