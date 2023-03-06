using PeopleManagement.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Domain.Entities
{
    public class PersonContact : EntityBase
    {
        public int Order { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public string ContactName { get; set; }
        public ContactType ContactType { get; set; }
        public Person Person { get; set; }
        public Guid PersonId { get; set; }
    }
}
