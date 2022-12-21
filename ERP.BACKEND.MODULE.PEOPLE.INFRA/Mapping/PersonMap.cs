namespace Erp.Backend.Module.PERSON.INFRA.Mapping
{
    using Erp.Backend.Module.PERSON.DOMAIN.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PersonMap : BaseMap<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);
            builder.ToTable("PERSON");
            builder.Property(c => c.Name).IsRequired().HasColumnName("Name").HasMaxLength(255);
        }
    }
}
