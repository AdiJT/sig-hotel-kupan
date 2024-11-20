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
                KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                TitikKoordinat = new Point(-10.17875, 123.63906)
            },
            new LokasiPenting
            {
                Id = 5,
                Nama = "Beer & Barrel Kitchen n’Lounge",
                KategoriLokasiPenting = KategoriLokasiPenting.Restoran,
                TitikKoordinat = new Point(-10.14989, 123.60397)
            },
            new LokasiPenting
             {
            Id = 6,
                Nama = "Salon Eleanor",
                KategoriLokasiPenting = KategoriLokasiPenting.Salon,
                TitikKoordinat = new Point(-10.155096345033012, 123.64263013615513)
            },
            new LokasiPenting
            {
                Id = 7,
                Nama = "Lippo Plaza Kupang",
                KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                TitikKoordinat = new Point(-10.158797785189762, 123.61120806684349)
            },

             new LokasiPenting
             {
                 Id = 8,
                 Nama = "Toko Surya Mas",
                 KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                 TitikKoordinat = new Point(-10.154731547073125, 123.63101603645133)
             },

              new LokasiPenting
              {
                  Id = 9,
                  Nama = "Toko Miafa Fashion & Shoes",
                  KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                  TitikKoordinat = new Point(-10.14504152615265, 123.65515889382712)
              },

              new LokasiPenting
              {
                  Id = 10,
                  Nama = "TIARA SUPERMARKET NGAWI",
                  KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                  TitikKoordinat = new Point(-7.428149456794754, 111.44027486681163)
              },

              new LokasiPenting
              {
                  Id = 11,
                  Nama = "Apotik Tiara",
                  KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                  TitikKoordinat = new Point(-10.15619817736691, 123.65509376684349)
              },

              new LokasiPenting
              {
                  Id = 12,
                  Nama = "GMIT Jemaat Moria Liliba",
                  KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                  TitikKoordinat = new Point(-10.167341245894558, 123.65167980917163)
              },

              new LokasiPenting
              {
                  Id = 13,
                  Nama = "Gereja Katolik Stasi Yesus Maria Yosef GMIT Jemaat Moria Liliba",
                  KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                  TitikKoordinat = new Point(-10.163788224772084, 123.6456486243272)
              },

              new LokasiPenting
              {
                  Id = 14,
                  Nama = "Taman Adipura",
                  KategoriLokasiPenting = KategoriLokasiPenting.Taman,
                  TitikKoordinat = new Point(-10.16380934571496, 123.64565935316323)
              },

              new LokasiPenting
              {
                  Id = 15,
                  Nama = "Universitas Nusa Cendana",
                  KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                  TitikKoordinat = new Point(-10.152699366087724, 123.65829785425603)
              },

              new LokasiPenting
              {
                  Id = 16,
                  Nama = "Monumen Tunas Kelapa ",
                  KategoriLokasiPenting = KategoriLokasiPenting.TempatWisata,
                  TitikKoordinat = new Point(-10.151246559346196, 123.65984990898286)
              },

              new LokasiPenting
              {
                  Id = 17,
                  Nama = "Dapur Nekamese",
                  KategoriLokasiPenting = KategoriLokasiPenting.Restoran,
                  TitikKoordinat = new Point(-10.165560223371887, 123.65692905501547)
              },

              new LokasiPenting
              {
                  Id = 18,
                  Nama = "RSU. Mamami",
                  KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                  TitikKoordinat = new Point(-10.153436634299652, 123.60905405396625)
              },

              new LokasiPenting
              {
                  Id = 19,
                  Nama = "Alun-Alun Kota Kupang",
                  KategoriLokasiPenting = KategoriLokasiPenting.TempatWisata,
                  TitikKoordinat = new Point(-10.14858481926448, 123.61006343781891)
              },

              new LokasiPenting
              {
                  Id = 20,
                  Nama = "Pantai Warna Kota Kupang NTT",
                  KategoriLokasiPenting = KategoriLokasiPenting.TempatWisata,
                  TitikKoordinat = new Point(-10.142297333458645, 123.65380353781883)
              },

               new LokasiPenting
               {
                   Id = 21,
                   Nama = "Masjid Al Fatah",
                   KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                   TitikKoordinat = new Point(-10.160191538785286, 123.5828728819992)
               },

               new LokasiPenting
               {
                   Id = 22,
                   Nama = "La Moringa Kupang",
                   KategoriLokasiPenting = KategoriLokasiPenting.Restoran,
                   TitikKoordinat = new Point(-10.17437418183125, 123.61804103862426)
               },

               new LokasiPenting
               {
                   Id = 23,
                   Nama = "RSUD Prof. Dr. W Z Johannes Kupang",
                   KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                   TitikKoordinat = new Point(-10.168073482596304, 123.58570260898844)
               },

               new LokasiPenting
               {
                   Id = 24,
                   Nama = "Toko Utama Karya",
                   KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                   TitikKoordinat = new Point(-10.156178314225947, 123.62437612883605)
               },

               new LokasiPenting
               {
                   Id = 25,
                   Nama = "Matahari Department Store Kupang",
                   KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                   TitikKoordinat = new Point(-10.157911990050708, 123.61104298650814)
               },

                new LokasiPenting
                {
                    Id = 26,
                    Nama = "Global Sport",
                    KategoriLokasiPenting = KategoriLokasiPenting.FasilitasOlahraga,
                    TitikKoordinat = new Point(-10.178603640220404, 123.61893323068838)
                },

                 new LokasiPenting
                 {
                     Id = 27,
                     Nama = "Solaria - Transmart Carrefour Kupang",
                     KategoriLokasiPenting = KategoriLokasiPenting.Restoran,
                     TitikKoordinat = new Point(-10.170114897390764, 123.60853995952444)
                 },

                 new LokasiPenting
                 {
                     Id = 28,
                     Nama = "Rumah Sakit Wirasakti",
                     KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                     TitikKoordinat = new Point(-10.166203375321446, 123.58338487116394)
                 },

                 new LokasiPenting
                 {
                     Id = 29,
                     Nama = "Stadion Merdeka",
                     KategoriLokasiPenting = KategoriLokasiPenting.FasilitasOlahraga,
                     TitikKoordinat = new Point(-10.160573767776516, 123.58950063030237)
                 },

                 new LokasiPenting
                 {
                     Id = 30,
                     Nama = "Transmart Kupang",
                     KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                     TitikKoordinat = new Point(-10.170046435805768, 123.60911297301628)
                 },

                 new LokasiPenting
                 {
                     Id = 31,
                     Nama = "Kharisma Stationery Kupang",
                     KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                     TitikKoordinat = new Point(-10.169480654673883, 123.6062982558198)
                 },

                 new LokasiPenting
                 {
                     Id = 32,
                     Nama = "Ramayana Kupang",
                     KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                     TitikKoordinat = new Point(-10.173755599772544, 123.61301958560706)
                 },

                  new LokasiPenting
                  {
                      Id = 33,
                      Nama = "POLTEKKKES KEMENKES KUPANG",
                      KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                      TitikKoordinat = new Point(-10.158172375407423, 123.6396026423279)
                  },

                  new LokasiPenting
                  {
                      Id = 34,
                      Nama = "RSU LEONA",
                      KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                      TitikKoordinat = new Point(-10.170704857825687, 123.62746611349189)
                  },

                  new LokasiPenting
                  {
                      Id = 35,
                      Nama = "Siloam Hospitals Kupang",
                      KategoriLokasiPenting = KategoriLokasiPenting.FasilitasKesehatan,
                      TitikKoordinat = new Point(-10.157267514513673, 123.61045065952203)
                  },

                  new LokasiPenting
                  {
                      Id = 36,
                      Nama = "Universitas Muhammadiyah Kupang",
                      KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                      TitikKoordinat = new Point(-10.162443506832757, 123.62013012170553)
                  },

                  new LokasiPenting
                  {
                      Id = 37,
                      Nama = "Universitas Katolik Widya Mandira",
                      KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                      TitikKoordinat = new Point(-10.15985435160967, 123.5875447799001)
                  },

                  new LokasiPenting
                  {
                      Id = 38,
                      Nama = "Universitas Katolik Widya Mandira",
                      KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                      TitikKoordinat = new Point(-10.15985435160967, 123.5875447799001)
                  },

                  new LokasiPenting
                  {
                      Id = 39,
                      Nama = "Stadion Oepoi Kupang",
                      KategoriLokasiPenting = KategoriLokasiPenting.FasilitasOlahraga,
                      TitikKoordinat = new Point(-10.175571279105565, 123.61709251999608)
                  },

                  new LokasiPenting
                  {
                      Id = 40,
                      Nama = "Masjid Nurul Wathan",
                      KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                      TitikKoordinat = new Point(-10.173093317895201, 123.59498006455591)
                  },

                  new LokasiPenting
                  {
                      Id = 41,
                      Nama = "GMIT Jemaat Koinonia Kuanino",
                      KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                      TitikKoordinat = new Point(-10.171496317208604, 123.59019342090117)
                  },

                  new LokasiPenting
                  {
                      Id = 42,
                      Nama = "Taman TAGEPE (Taman Generasi Penerus )",
                      KategoriLokasiPenting = KategoriLokasiPenting.Taman,
                      TitikKoordinat = new Point(-10.149518820274524, 123.62414809657113)
                  },

                  new LokasiPenting
                  {
                      Id = 43,
                      Nama = "Taman Ina Bo'i",
                      KategoriLokasiPenting = KategoriLokasiPenting.Taman,
                      TitikKoordinat = new Point(-10.151117152372697, 123.60838003456588)
                  },

                  new LokasiPenting
                   {
                       Id = 44,
                       Nama = "Pantai Paradiso",
                       KategoriLokasiPenting = KategoriLokasiPenting.TempatWisata,
                       TitikKoordinat = new Point(-10.140874244894492, 123.62691141664712)
                   },

                   new LokasiPenting
                    {
                        Id = 45,
                        Nama = "UNIVERSITAS KARYADARMA KUPANG",
                        KategoriLokasiPenting = KategoriLokasiPenting.Universitas,
                        TitikKoordinat = new Point(-10.18226634155387, 123.59561464418024)
                    },

                   new LokasiPenting
                   {
                       Id = 46,
                       Nama = "Taman Kota Fontein",
                       KategoriLokasiPenting = KategoriLokasiPenting.Taman,
                       TitikKoordinat = new Point(-10.163674464657998, 123.58188383280957)
                   },

                   new LokasiPenting
                   {
                       Id = 47,
                       Nama = "Pelabuhan Kupang",
                       KategoriLokasiPenting = KategoriLokasiPenting.Pelabuhan,
                       TitikKoordinat = new Point(-10.192631229586887, 123.52449042537158)
                   },

                   new LokasiPenting
                   {
                       Id = 48,
                       Nama = "Batu Kapala Beach",
                       KategoriLokasiPenting = KategoriLokasiPenting.TempatWisata,
                       TitikKoordinat = new Point(-10.164666670052334, 123.57056615383524)
                   },

                   new LokasiPenting
                   {
                       Id = 49,
                       Nama = "Flobamora Mall",
                       KategoriLokasiPenting = KategoriLokasiPenting.PusatBelanja,
                       TitikKoordinat = new Point(-10.174087584077462, 123.6130504310108)
                   },

                   new LokasiPenting
                   {
                       Id = 50,
                       Nama = "Masjid Nurul Iman Oebobo",
                       KategoriLokasiPenting = KategoriLokasiPenting.TempatIbadah,
                       TitikKoordinat = new Point(-10.16977477539389, 123.60293285158959)
                   },

                   new LokasiPenting
                   {
                       Id = 51,
                       Nama = "Sekolah Menengah Kejuruan Negeri 3 Kupang",
                       KategoriLokasiPenting = KategoriLokasiPenting.Sekolah,
                       TitikKoordinat = new Point(-10.153117835061147, 123.6182331627036)
                   },

                   new LokasiPenting
                   {
                       Id = 52,
                       Nama = "Taman Nostalgia",
                       KategoriLokasiPenting = KategoriLokasiPenting.Taman,
                       TitikKoordinat = new Point(-10.159171290674566, 123.61594032831051)
                   },

                   new LokasiPenting
                   {
                       Id = 53,
                       Nama = "Gedung Pramuka",
                       KategoriLokasiPenting = KategoriLokasiPenting.Sekolah,
                       TitikKoordinat = new Point(-10.151585630398712, 123.66028788783497)
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
        modelBuilder.Entity<HargaKamarHotel>().HasData(
            new HargaKamarHotel
            {
                IdHotel = 1,
                IdTipeKamar = 2,
                HargaKamar = 280561
            },
            new HargaKamarHotel
            {
                IdHotel = 1,
                IdTipeKamar = 3,
                HargaKamar = 362211
            },
            new HargaKamarHotel
            {
                IdHotel = 1,
                IdTipeKamar = 4,
                HargaKamar = 403021
            },
            new HargaKamarHotel
            {
                IdHotel = 2,
                IdTipeKamar = 2,
                HargaKamar = 100000
            },
            new HargaKamarHotel
            {
                IdHotel = 3,
                IdTipeKamar = 1,
                HargaKamar = 182182
            },
            new HargaKamarHotel
            {
                IdHotel = 5,
                IdTipeKamar = 1,
                HargaKamar = 133869
            },
            new HargaKamarHotel
            {
                IdHotel = 7,
                IdTipeKamar = 5,
                HargaKamar = 125382
            },
            new HargaKamarHotel
            {
                IdHotel = 7,
                IdTipeKamar = 6,
                HargaKamar = 134338
            }
        );
        #endregion

        return modelBuilder;
    }
}
