namespace ERP.BACKEND.MODULE.PERSON.INFRA.Mapping
{
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;

    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("Id");
        }
    }
}
