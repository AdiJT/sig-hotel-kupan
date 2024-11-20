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
            },
            new Fasilitas
            {
            Id = 5,
                Nama = "Rental Mobil"
            },
             new Fasilitas
             {
                 Id = 6,
                 Nama = "Sarapan"
             },
              new Fasilitas
              {
                  Id = 7,
                  Nama = "Restoran"
              },
               new Fasilitas
               {
                   Id = 8,
                   Nama = "Resepsionis 24 jam"
               },
                new Fasilitas
                {
                    Id = 9,
                    Nama = "Layanan pemesanan taxi"
                }, 
                new Fasilitas
                {
                    Id = 10,
                    Nama = "Ruang multi-fungsi"
                },
                new Fasilitas
                 {
                     Id = 11,
                     Nama = "Laundry"
                 },
                 new Fasilitas
                 {
                     Id = 12,
                     Nama = "Beach access"
                 },
                  new Fasilitas
                  {
                      Id = 13,
                      Nama = "Kid-friendly"
                  },
                   new Fasilitas
                   {
                       Id = 14,
                       Nama = "Airport Shuttle"
                   },
                    new Fasilitas
                    {
                        Id = 15,
                        Nama = "Rental Sepeda"
                    },
                     new Fasilitas
                     {
                         Id = 16,
                         Nama = "Meet Room"
                     },
                      new Fasilitas
                      {
                          Id = 17,
                          Nama = "Outdoor pool"
                      },
                       new Fasilitas
                       {
                           Id = 18,
                           Nama = "Restaurant"
                       },
                        new Fasilitas
                        {
                            Id = 19,
                            Nama = "Cofee Shop"
                        },
                         new Fasilitas
                         {
                             Id = 20,
                             Nama = "Family room"
                         },
                          new Fasilitas
                          {
                              Id = 21,
                              Nama = "Toko"
                          },
                           new Fasilitas
                           {
                               Id = 22,
                               Nama = "smooking area"
                           },
                            new Fasilitas
                            {
                                Id = 23,
                                Nama = "TV"
                            },
                             new Fasilitas
                             {
                                 Id = 24,
                                 Nama = "Staf Multibahasa"
                             },
                              new Fasilitas
                              {
                                  Id = 25,
                                  Nama = "Fasilitas Rpat"
                              },
                               new Fasilitas
                               {
                                   Id = 26,
                                   Nama = "Pancuran"
                               },
                                new Fasilitas
                                {
                                    Id = 27,
                                    Nama = "Check in & Check out ekspress"
                                },
                                 new Fasilitas
                                 {
                                     Id = 28,
                                     Nama = "Parkir bagi penyandang disabilitas"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 29,
                                     Nama = "Bar"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 30,
                                     Nama = "Security [24-hour]"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 31,
                                     Nama = "Dapur"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 32,
                                     Nama = "Balcony"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 33,
                                     Nama = "Lift"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 34,
                                     Nama = "Tempat Fitness"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 35,
                                     Nama = "Kulkas"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 36,
                                     Nama = "Layanan Kesehatan"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 37,
                                     Nama = "Taman"
                                 },
                                 new Fasilitas
                                 {
                                     Id = 38,
                                     Nama = "Aula"
                                 },
                                new Fasilitas
                                {
                                    Id = 39,
                                    Nama = "Perlengkapan Mandi"
                                },
                                new Fasilitas
                                {
                                    Id = 40,
                                    Nama = "Kopi dan Snack"
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
