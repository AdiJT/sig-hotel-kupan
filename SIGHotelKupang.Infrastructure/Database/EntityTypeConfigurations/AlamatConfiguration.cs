using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database.EntityTypeConfigurations;

internal class AlamatConfiguration : IEntityTypeConfiguration<Alamat>
{
    public void Configure(EntityTypeBuilder<Alamat> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasOne(a => a.Hotel).WithOne(h => h.Alamat).HasForeignKey(nameof(Alamat));
    }
}
