using PeopleManagement.Common.Tools.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Application.DTOs.Requests.Person
{
    public class PersonUpdateRequest
    {
        public Guid Id { get; set; } = Guid.Empty;
        public string Name { get; set; } = string.Empty;
        public string? CorporateName { get; set; }
        public DateTime? BirthDate { get; set; }
        public SexEnum? Sex { get; set; }
        public string CpfCnpj { get; set; } = string.Empty;
        public PersonType Type { get; set; }
        public string? StateRegistration { get; set; }
    }
}
