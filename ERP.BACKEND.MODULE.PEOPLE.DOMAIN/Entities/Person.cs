using ERP.BACKEND.MODULE.PERSON.COMMON.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities
{
    public class Person : EntityBase
    {
        public string Name { get; set; }
        public string? CorporateName { get; set; }
        public DateTime? BirthDate { get; set; }
        public SexEnum? Sex { get; set; }
        public string CpfCnpj { get; set; }
        public TypeEnum Type { get; set; }
        public string? StateRegistration { get; set; }
    }
}
