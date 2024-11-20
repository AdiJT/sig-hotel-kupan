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
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Nama = "Chrysant Hotel & Resort",
                KlasifikasiHotel = KlasifikasiHotel.HotelBintang4,
                NomorTelepon = "0822-3722-6973",
                Rating = 4,
                JumlahKamar = 28,
                BatasBawahJamCheckIn = new TimeOnly(14, 00),
                BatasAtasJamCheckIn = new TimeOnly(0, 0),
                BatasBawahJamCheckOut = new TimeOnly(0, 0),
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.18563, 123.66373),
            },
            new Hotel
            {
                Id = 2,
                Nama = "Ladang Mas Homestay",
                KlasifikasiHotel = KlasifikasiHotel.HomeStay,
                NomorTelepon = "(021) 80629666",
                Rating = 5.0,
                JumlahKamar = 3,
                BatasBawahJamCheckIn = new TimeOnly(14, 0),
                BatasAtasJamCheckIn = new TimeOnly(23, 59),
                BatasBawahJamCheckOut = new TimeOnly(7, 0),
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.1675, 123.6461),
            },
            new Hotel
            {
                Id = 3,
                Nama = "Kopa Guest House",
                KlasifikasiHotel = KlasifikasiHotel.Guesthouse,
                NomorTelepon = "",
                Rating = 4.6,
                JumlahKamar = 3,
                BatasBawahJamCheckIn = null,
                BatasAtasJamCheckIn = null,
                BatasBawahJamCheckOut = null,
                BatasAtasJamCheckOut = new TimeOnly(15, 0),
                TitikKoordinat = new Point(-10.15938, 123.64315),
            },
            new Hotel
            {
                Id = 4,
                Nama = "Satria Homestay",
                KlasifikasiHotel = KlasifikasiHotel.HomeStay,
                NomorTelepon = "0821-4030-1904",
                Rating = 4.6,
                JumlahKamar = 9,
                BatasBawahJamCheckIn = new TimeOnly(14, 0),
                BatasAtasJamCheckIn = null,
                BatasBawahJamCheckOut = null,
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.16343, 123.65602),
            },
            new Hotel
            {
                Id = 5,
                Nama = "Homestay Karo Bobe",
                KlasifikasiHotel = KlasifikasiHotel.HomeStay,
                NomorTelepon = "082144728877",
                Rating = 4.6,
                JumlahKamar = 9,
                BatasBawahJamCheckIn = new TimeOnly(14, 0),
                BatasAtasJamCheckIn = new TimeOnly(22, 50),
                BatasBawahJamCheckOut = new TimeOnly(0, 1),
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.16394, 123.66803),
            },
            new Hotel
            {
                Id = 6,
                Nama = "OCD Beach Cafe & Hostel",
                KlasifikasiHotel = KlasifikasiHotel.Hostel,
                NomorTelepon = "0852-3915-9401",
                Rating = 4.4,
                JumlahKamar = 1,
                BatasBawahJamCheckIn = new TimeOnly(13, 0),
                BatasAtasJamCheckIn = new TimeOnly(13, 0),
                BatasBawahJamCheckOut = new TimeOnly(12, 0),
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.13221, 123.66984),
            },
            new Hotel
            {
                Id = 7,
                Nama = "RedDoorz Near Mangrove Forest",
                KlasifikasiHotel = KlasifikasiHotel.Reddoorz,
                NomorTelepon = "(021) 80629666",
                Rating = 4.2,
                JumlahKamar = 3,
                BatasBawahJamCheckIn = new TimeOnly(14, 0),
                BatasAtasJamCheckIn = new TimeOnly(16, 0),
                BatasBawahJamCheckOut = null,
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.14905, 123.64554),
                Website = new Uri("https://www.reddoorz.com")
            },
            new Hotel
            {
                Id = 8,
                Nama = "Mai Mai Homestay",
                KlasifikasiHotel = KlasifikasiHotel.HomeStay,
                NomorTelepon = "(021) 80629666",
                Rating = 4.4,
                JumlahKamar = 17,
                BatasBawahJamCheckIn = new TimeOnly(14, 0),
                BatasAtasJamCheckIn = null,
                BatasBawahJamCheckOut = null,
                BatasAtasJamCheckOut = new TimeOnly(12, 0),
                TitikKoordinat = new Point(-10.18846, 123.61535)
            }
        );
        #endregion

        #region Alamat 
        modelBuilder.Entity<Alamat>().HasData(
            new
            {
                Id = 1,
                Jalan = "Jl. Antonov",
                KodePos = "85361",
                Kelurahan = "Baumata Barat",
                Kecamatan = "Taebenu",
                HotelId = 1
            },
            new
            {
                Id = 2,
                Jalan = "Ladang Mas Mini Market",
                KodePos = "85111",
                Kelurahan = "Liliba",
                Kecamatan = "Kelapa Lima",
                HotelId = 2
            },
            new
            {
                Id = 3,
                Jalan = "Jl. Bumi 1 gang 3",
                KodePos = "85111",
                Kelurahan = "Liliba",
                Kecamatan = "Kelapa Lima",
                HotelId = 3
            },
            new
            {
                Id = 4,
                Jalan = "Jl. Libra No.4",
                KodePos = "85111",
                Kelurahan = "Liliba",
                Kecamatan = "Kelapa Lima",
                HotelId = 4
            },
            new
            {
                Id = 5,
                Jalan = "",
                KodePos = "85148",
                Kelurahan = "Penfui",
                Kecamatan = "Kupang Tengah",
                HotelId = 5
            },
            new
            {
                Id = 6,
                Jalan = "Jl. Terusan Timor Raya",
                KodePos = "85228",
                Kelurahan = "Lasiana",
                Kecamatan = "Kelapa Lima",
                HotelId = 6
            },
            new
            {
                Id = 7,
                Jalan = "Jl. Terusan Timor Raya No.KM.8",
                KodePos = "85228",
                Kelurahan = "Oesapa",
                Kecamatan = "Kelapa Lima",
                HotelId = 7
            },
            new
            {
                Id = 8,
                Jalan = "Jl. Siwalan No.2",
                KodePos = "85142",
                Kelurahan = "Maulafa",
                Kecamatan = "Maulafa",
                HotelId = 8
            }
        );
        #endregion

        #region FasilitasHotel
        modelBuilder.Entity<FasilitasHotel>().HasData(
            new FasilitasHotel
            {
                HotelId = 1,
                FasilitasId = 1
            },
            new FasilitasHotel
            {
                HotelId = 1,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 1,
                FasilitasId = 3
            },
            new FasilitasHotel
            {
                HotelId = 1,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 2,
                FasilitasId = 1
            },
            new FasilitasHotel
            {
                HotelId = 2,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 2,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 3,
                FasilitasId = 1
            },
            new FasilitasHotel
            {
                HotelId = 3,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 3,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 4,
                FasilitasId = 1
            },
            new FasilitasHotel
            {
                HotelId = 4,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 4,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 5,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 6,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 6,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 7,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 7,
                FasilitasId = 4
            },
            new FasilitasHotel
            {
                HotelId = 8,
                FasilitasId = 1
            },
            new FasilitasHotel
            {
                HotelId = 8,
                FasilitasId = 2
            },
            new FasilitasHotel
            {
                HotelId = 8,
                FasilitasId = 4
            }
        );
        #endregion

        #region HargaKamarHotel

        #endregion

        return modelBuilder;
    }
}
