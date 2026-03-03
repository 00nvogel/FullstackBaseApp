using BaseBackendReduced.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BaseBackendReduced.Infrastructure.Configurations;

internal class ExampleModelConfiguration : IEntityTypeConfiguration<ExampleModel>
{
    public void Configure(EntityTypeBuilder<ExampleModel> builder)
    {
        builder.ToTable("examples");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(200);
    }
}
