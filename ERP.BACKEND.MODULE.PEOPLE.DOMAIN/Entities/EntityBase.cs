namespace Erp.Backend.Module.PERSON.DOMAIN.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
