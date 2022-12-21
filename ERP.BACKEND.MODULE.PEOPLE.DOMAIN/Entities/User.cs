namespace Erp.Backend.Module.PERSON.DOMAIN.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class User : EntityBase
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;
    }
}
