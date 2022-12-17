using ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs;
using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.Interfaces
{
    public interface IPersonApplication : IApplicationBase<Person, PersonDTO>
    {
    }
}
