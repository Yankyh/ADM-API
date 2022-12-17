using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PERSON.INFRA.Mapping
{
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
