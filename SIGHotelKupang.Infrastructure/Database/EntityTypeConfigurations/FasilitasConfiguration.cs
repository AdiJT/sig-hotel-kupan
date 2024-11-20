using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database.EntityTypeConfigurations;

internal class FasilitasConfiguration : IEntityTypeConfiguration<Fasilitas>
{
    public void Configure(EntityTypeBuilder<Fasilitas> builder)
    {
        builder.HasKey(f => f.Id);

        builder.HasMany(f => f.DaftarHotel).WithMany(h => h.DaftarFasilitas).UsingEntity<FasilitasHotel>();
    }
}
