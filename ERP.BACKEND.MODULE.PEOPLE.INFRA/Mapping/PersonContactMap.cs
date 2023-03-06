using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManagement.Infra.Mapping
{
    public class PersonContactMap : BaseMap<PersonContact>
    {
        public override void Configure(EntityTypeBuilder<PersonContact> builder)
        {
            base.Configure(builder);
            builder.ToTable("PERSON_CONTACT");
            builder.Property(c => c.Order).HasColumnName("Order").IsRequired();
            builder.Property(c => c.ContactType).HasColumnName("ContactType").IsRequired();
            builder.Property(c => c.Observation).HasColumnName("Observation").HasMaxLength(255);
            builder.Property(c => c.ContactName).HasColumnName("ContactName").HasMaxLength(255).IsRequired();
            builder.Property(c => c.Description).HasColumnName("Description").HasMaxLength(255).IsRequired();
            builder.Property(c => c.Value).HasColumnName("Description").HasMaxLength(255);
            builder.Property(c => c.PersonId).HasColumnName("Person").IsRequired();
        }
    }
}
