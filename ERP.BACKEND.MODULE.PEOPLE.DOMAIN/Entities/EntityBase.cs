namespace ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
