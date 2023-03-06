using PeopleManagement.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Application.DTOs.Requests.PersonContact
{
    public class PersonContactUpdateRequest
    {
        public Guid Id { get; set; } = Guid.Empty;
        public int Order { get; set; } = 0;
        public string Value { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Observation { get; set; } = String.Empty;
        public string ContactName { get; set; } = String.Empty;
        public ContactType ContactType { get; set; } = ContactType.PhoneNumber;
    }
}
