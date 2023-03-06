namespace PeopleManagement.Infra.Contexts
{
    using PeopleManagement.Domain.Entities;
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
            modelBuilder.Entity<PersonContact>()
            .ToTable("PersonContact")
            .HasOne(p => p.Person)
            .WithMany(pc => pc.PersonContacts)
            .HasForeignKey(p => p.PersonId);

        }
    }
}
