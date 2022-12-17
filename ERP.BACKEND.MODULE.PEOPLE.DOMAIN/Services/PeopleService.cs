using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Repositories;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Interfaces.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Services
{
    public class PeopleService : ServiceBase<People>, IPeopleService
    {
        public PeopleService(IPeopleRepository repositorio) : base(repositorio)
        {

        }

    }
}
