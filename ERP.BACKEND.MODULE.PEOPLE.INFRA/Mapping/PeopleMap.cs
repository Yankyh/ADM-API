using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.BACKEND.MODULE.PEOPLE.INFRA.Mapping
{
    public class PeopleMap : BaseMap<People>
    {
        public override void Configure(EntityTypeBuilder<People> builder)
        {
            base.Configure(builder);
            builder.ToTable("PEOPLE");
            builder.Property(c => c.Name).IsRequired().HasColumnName("Name").HasMaxLength(255);
        }
    }
}
