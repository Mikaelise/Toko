using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Toko.EFCore.Domain.Entities.Illustrator;
using System.Reflection;

namespace Toko.EFCore.Infrastructure.Configurations
{
    public class IllustratorConfiguration : IEntityTypeConfiguration<Illustrator>
    {
        public void Configure(EntityTypeBuilder<Illustrator> builder)
        {
            builder.ToTable("Illustrators");

            builder.Property(x => x.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
