using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteTakingApp.Backend.Domain.Notes;

namespace NoteTakingApp.Backend.Persistence.Configurations
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(n => n.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(n => n.Content)
                .IsRequired()
                .HasMaxLength(500);

            builder.ToTable("Notes");
        }
    }
}
