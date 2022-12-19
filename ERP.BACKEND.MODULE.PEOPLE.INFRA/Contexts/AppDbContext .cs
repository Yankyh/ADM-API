namespace ERP.BACKEND.MODULE.PERSON.INFRA.Contexts
{
    using ERP.BACKEND.MODULE.PERSON.DOMAIN.Entities;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
