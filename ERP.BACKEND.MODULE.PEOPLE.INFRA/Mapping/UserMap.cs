namespace PeopleManagement.Infra.Mapping
{
    using PeopleManagement.Domain.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserMap : BaseMap<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("USER");
            builder.Property(c => c.Name).IsRequired().HasColumnName("Name").HasMaxLength(255);
            builder.Property(c => c.Password).IsRequired().HasColumnName("Password").HasMaxLength(255);
            builder.Property(c => c.Email).IsRequired().HasColumnName("Email").HasMaxLength(255);
        }
    }
}
