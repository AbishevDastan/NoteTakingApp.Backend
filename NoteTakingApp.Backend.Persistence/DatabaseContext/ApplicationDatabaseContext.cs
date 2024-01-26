using Microsoft.EntityFrameworkCore;
using NoteTakingApp.Backend.Domain.Notes;

namespace NoteTakingApp.Backend.Persistence.DatabaseContext
{
    public class ApplicationDatabaseContext : DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDatabaseContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
