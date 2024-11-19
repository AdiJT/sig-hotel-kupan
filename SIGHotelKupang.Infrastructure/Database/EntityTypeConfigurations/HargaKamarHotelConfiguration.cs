using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database.EntityTypeConfigurations;

internal class HargaKamarHotelConfiguration : IEntityTypeConfiguration<HargaKamarHotel>
{
    public void Configure(EntityTypeBuilder<HargaKamarHotel> builder)
    {
        builder.HasKey(h => new { h.IdHotel, h.IdTipeKamar });

        builder.HasOne(h => h.Hotel).WithMany(h => h.DaftarHargaKamarHotel).HasForeignKey(h => h.IdHotel);
        builder.HasOne(h => h.TipeKamar).WithMany(h => h.DaftarHargaKamarHotel).HasForeignKey(h => h.IdTipeKamar);
    }
}
