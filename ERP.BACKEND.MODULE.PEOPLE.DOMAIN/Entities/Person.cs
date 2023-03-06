namespace PeopleManagement.Domain.Entities
{
    using PeopleManagement.Common.Tools.Enums;
    using System.ComponentModel.DataAnnotations;

    public class Person : EntityBase
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? CorporateName { get; set; }
        public DateTime? BirthDate { get; set; }
        public SexEnum? Sex { get; set; }
        [Required]
        public string CpfCnpj { get; set; } = string.Empty;
        [Required]
        public PersonType Type { get; set; }
        public string? StateRegistration { get; set; }
        public List<PersonContact> PersonContacts { get; set; }
    }
}
