using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database.EntityTypeConfigurations;

public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
{
    public void Configure(EntityTypeBuilder<Hotel> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.TitikKoordinat).HasColumnType("geography (point)");

        builder.HasOne(x => x.Alamat).WithOne(x => x.Hotel);
        builder.HasMany(x => x.DaftarFasilitas).WithMany(x => x.DaftarHotel).UsingEntity<FasilitasHotel>();
        builder.HasMany(x => x.DaftarHargaKamarHotel).WithOne(k => k.Hotel).HasForeignKey(k => k.IdHotel);
    }
}
