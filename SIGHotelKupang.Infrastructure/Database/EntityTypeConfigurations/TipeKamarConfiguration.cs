using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database.EntityTypeConfigurations;

internal class TipeKamarConfiguration : IEntityTypeConfiguration<TipeKamar>
{
    public void Configure(EntityTypeBuilder<TipeKamar> builder)
    {
        builder.HasKey(t => t.Id);

        builder.HasMany(t => t.DaftarHargaKamarHotel).WithOne(h => h.TipeKamar).HasForeignKey(h => h.IdTipeKamar);
    }
}
