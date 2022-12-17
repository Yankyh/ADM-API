using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.BACKEND.MODULE.PEOPLE.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;

namespace ERP.BACKEND.MODULE.PEOPLE.INFRA.Contexts
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<People> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<People>().ToTable("People");
        }
    }
}
