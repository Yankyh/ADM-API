using ERP.BACKEND.MODULE.PERSON.COMMON.Enums;
using System.ComponentModel.DataAnnotations;

namespace ERP.BACKEND.MODULE.PERSON.APPLICATION.DTOs
{
    public class PersonDTO : BaseDTO
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
