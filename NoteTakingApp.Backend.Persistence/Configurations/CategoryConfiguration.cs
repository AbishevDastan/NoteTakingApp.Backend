using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NoteTakingApp.Backend.Domain.Categories;

namespace NoteTakingApp.Backend.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Id).IsRequired().ValueGeneratedOnAdd();

            builder.Property(n => n.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.ToTable("Categories");
        }
    }
}
