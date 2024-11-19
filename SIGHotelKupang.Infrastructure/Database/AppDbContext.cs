using Microsoft.EntityFrameworkCore;
using SIGHotelKupang.Domain.Entities;

namespace SIGHotelKupang.Infrastructure.Database;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {   
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(AssemblyReferences.Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Hotel> TblHotel { get; set; }
    public DbSet<Alamat> TblAlamat { get; set; }
    public DbSet<Fasilitas> TblFasilitas { get; set; }
    public DbSet<TipeKamar> TblTipeKamar { get; set; }
    public DbSet<HargaKamarHotel> TblHargaKamarHotel { get; set; }
    public DbSet<LokasiPenting> TblLokasiPenting { get; set; }
}
