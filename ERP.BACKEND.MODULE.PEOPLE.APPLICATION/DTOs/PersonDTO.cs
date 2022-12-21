namespace Backend.Module.PERSON.APPLICATION.DTOs
{
    using Backend.Module.PERSON.COMMON.Enums;

    public class PersonDTO : BaseDTO
    {
        public string Name { get; set; } = string.Empty;
        public string? CorporateName { get; set; }
        public DateTime? BirthDate { get; set; }
        public SexEnum? Sex { get; set; }
        public string CpfCnpj { get; set; } = string.Empty;
        public PersonType Type { get; set; }
        public string? StateRegistration { get; set; }
    }
}
