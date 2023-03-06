using PeopleManagement.Common.Enums;
using PeopleManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Application.DTOs
{
    public class PersonContactDTO : BaseDTO
    {
        public Guid Id { get; set; } = Guid.Empty;
        public int Order { get; set; } = 0;
        public string Value { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Observation { get; set; } = String.Empty;
        public string ContactName { get; set; } = String.Empty;
        public ContactType ContactType { get; set; } = ContactType.PhoneNumber;
        public Person Person { get; set; } = new Person();
        public Guid PersonId { get; set; } = Guid.Empty;
    }
}
