using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;
using SIGHotelKupang.Domain.Entities;
using SIGHotelKupang.Domain.Enums;

namespace SIGHotelKupang.Infrastructure.Database;

public static class ModelBuilderExtension
{
    public static ModelBuilder SeedingData(this ModelBuilder modelBuilder)
    {
        #region Fasilitas
        modelBuilder.Entity<Fasilitas>().HasData(
            new Fasilitas
            {
                Id = 1,
                Nama = "AC (Air Conditioner)"
            },
            new Fasilitas
            {
                Id = 2,
                Nama = "WiFi"
            },
            new Fasilitas
            {
                Id = 3,
                Nama = "Kolam Renang"
            },
            new Fasilitas
            {
                Id = 4,
                Nama = "Parkir"
            }
        );
        #endregion

        #region TipeKamar
        modelBuilder.Entity<TipeKamar>().HasData(
            new TipeKamar
            {
                Id = 1,
                Nama = "Standard"
            },
            new TipeKamar
            {
                Id = 2,
                Nama = "Superior"
            },
            new TipeKamar
            {
                Id = 3,
                Nama = "Deluxe"
            },
            new TipeKamar
            {
                Id = 4,
                Nama = "Premium"
            },
            new TipeKamar
            {
                Id = 5,
                Nama = "Twin Room"
            },
            new TipeKamar
            {
                Id = 6,
                Nama = "Family Room"
            }
        );
        #endregion

        #region LokasiPenting
        modelBuilder.Entity<LokasiPenting>().HasData(
            new LokasiPenting
            {
                Id = 1,
                Nama = "Bandar Udara Internasional El Tari",
                KategoriLokasiPenting = KategoriLokasiPenting.BandarUdara,
                TitikKoordinat = new Point(-10.16846, 123.6679)
            },
            new LokasiPenting
            {
                Id = 2,
                Nama = "Nasipanaf",
                KategoriLokasiPenting = KategoriLokasiPenting.Sekolah,
                TitikKoordinat = new Point(-10.18067, 123.67391)
            },
            new LokasiPenting
            {
                Id = 3,
                Nama = "Lacaza Coffee & Homestay",
                KategoriLokasiPenting = KategoriLokasiPenting.KedaiKopi,
                TitikKoordinat = new Point(-10.16218, 123.65694)
            },
            new LokasiPenting
            {
                Id = 4,
                Nama = "Rumah Sakit Jiwa \"RSJ\" Naimata - Kupang",
                KategoriLokasiPenting = KategoriLokasiPenting.RumahSakit,
                TitikKoordinat = new Point(-10.17875, 123.63906)
            },
            new LokasiPenting
            {
                Id = 5,
                Nama = "Beer & Barrel Kitchen n’Lounge",
                KategoriLokasiPenting = KategoriLokasiPenting.Restoran,
                TitikKoordinat = new Point(-10.14989, 123.60397)
            }
        );
        #endregion

        #region Hotel

        #endregion

        #region Alamat 

        #endregion

        #region HargaKamarHotel

        #endregion

        return modelBuilder;
    }
}
