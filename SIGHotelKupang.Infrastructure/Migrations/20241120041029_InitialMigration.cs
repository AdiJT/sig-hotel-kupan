﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIGHotelKupang.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.CreateTable(
                name: "TblFasilitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFasilitas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblHotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    TitikKoordinat = table.Column<Point>(type: "geography (point)", nullable: false),
                    KlasifikasiHotel = table.Column<int>(type: "integer", nullable: false),
                    BatasBawahJamCheckIn = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    BatasAtasJamCheckIn = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    BatasBawahJamCheckOut = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    BatasAtasJamCheckOut = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    NomorTelepon = table.Column<string>(type: "text", nullable: false),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    FotoHotel = table.Column<string>(type: "text", nullable: false),
                    JumlahKamar = table.Column<int>(type: "integer", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    JumlahUlasan = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHotel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblLokasiPenting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false),
                    TitikKoordinat = table.Column<Point>(type: "geometry", nullable: false),
                    KategoriLokasiPenting = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblLokasiPenting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TblTipeKamar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTipeKamar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FasilitasHotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "integer", nullable: false),
                    FasilitasId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FasilitasHotel", x => new { x.FasilitasId, x.HotelId });
                    table.ForeignKey(
                        name: "FK_FasilitasHotel_TblFasilitas_FasilitasId",
                        column: x => x.FasilitasId,
                        principalTable: "TblFasilitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FasilitasHotel_TblHotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "TblHotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblAlamat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Jalan = table.Column<string>(type: "text", nullable: false),
                    KodePos = table.Column<string>(type: "text", nullable: false),
                    Kelurahan = table.Column<string>(type: "text", nullable: false),
                    Kecamatan = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAlamat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TblAlamat_TblHotel_Id",
                        column: x => x.Id,
                        principalTable: "TblHotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblHargaKamarHotel",
                columns: table => new
                {
                    IdHotel = table.Column<int>(type: "integer", nullable: false),
                    IdTipeKamar = table.Column<int>(type: "integer", nullable: false),
                    HargaKamar = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHargaKamarHotel", x => new { x.IdHotel, x.IdTipeKamar });
                    table.ForeignKey(
                        name: "FK_TblHargaKamarHotel_TblHotel_IdHotel",
                        column: x => x.IdHotel,
                        principalTable: "TblHotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TblHargaKamarHotel_TblTipeKamar_IdTipeKamar",
                        column: x => x.IdTipeKamar,
                        principalTable: "TblTipeKamar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TblFasilitas",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 1, "AC (Air Conditioner)" },
                    { 2, "WiFi" },
                    { 3, "Kolam Renang" },
                    { 4, "Parkir" },
                    { 5, "Rental Mobil" },
                    { 6, "Sarapan" },
                    { 7, "Restoran" },
                    { 8, "Resepsionis 24 jam" },
                    { 9, "Layanan pemesanan taxi" },
                    { 10, "Ruang multi-fungsi" },
                    { 11, "Laundry" },
                    { 12, "Beach access" },
                    { 13, "Kid-friendly" },
                    { 14, "Airport Shuttle" },
                    { 15, "Rental Sepeda" },
                    { 16, "Meet Room" },
                    { 17, "Outdoor pool" },
                    { 18, "Restaurant" },
                    { 19, "Cofee Shop" },
                    { 20, "Family room" },
                    { 21, "Toko" },
                    { 22, "smooking area" },
                    { 23, "TV" },
                    { 24, "Staf Multibahasa" },
                    { 25, "Fasilitas Rpat" },
                    { 26, "Pancuran" },
                    { 27, "Check in & Check out ekspress" },
                    { 28, "Parkir bagi penyandang disabilitas" },
                    { 29, "Bar" },
                    { 30, "Security [24-hour]" },
                    { 31, "Dapur" },
                    { 32, "Balcony" },
                    { 33, "Lift" },
                    { 34, "Tempat Fitness" },
                    { 35, "Kulkas" },
                    { 36, "Layanan Kesehatan" },
                    { 37, "Taman" },
                    { 38, "Aula" },
                    { 39, "Perlengkapan Mandi" },
                    { 40, "Kopi dan Snack" }
                });

            migrationBuilder.InsertData(
                table: "TblHotel",
                columns: new[] { "Id", "BatasAtasJamCheckIn", "BatasAtasJamCheckOut", "BatasBawahJamCheckIn", "BatasBawahJamCheckOut", "Email", "FotoHotel", "JumlahKamar", "JumlahUlasan", "KlasifikasiHotel", "Nama", "NomorTelepon", "Rating", "TitikKoordinat", "Website" },
                values: new object[,]
                {
                    { 1, new TimeOnly(0, 0, 0), new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), new TimeOnly(0, 0, 0), "", "data:image/jpeg;base64,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", 28, 292, 5, "Chrysant Hotel & Resort", "0822-3722-6973", 4.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.18563 123.66373)"), null },
                    { 2, new TimeOnly(23, 59, 0), new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), new TimeOnly(7, 0, 0), "", "https://streetviewpixels-pa.googleapis.com/v1/thumbnail?panoid=9CM6ZVTe7ihms4XQ2fwOVw&cb_client=search.gws-prod.gps&w=408&h=240&yaw=294.1287&pitch=0&thumbfov=100", 3, 2, 8, "Ladang Mas Homestay", "(021) 80629666", 5.0, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.1675 123.6461)"), null },
                    { 3, null, new TimeOnly(15, 0, 0), null, null, "", "https://lh3.googleusercontent.com/gps-proxy/ALd4DhGLHBXqh7oVk6Nvhj5jr1e3u6g4_7MBNjckMLGKajXOLL_8RjdVxUVZe4NaqwEG47mNa88F54iFGaw8tIfMfRRkWdOjuzHiNTtDvRTG5xMmdz3jdqiblLyN-WGnE0VV-F_27176ZytIR_-QnKUrJckdnld-Ld4cZv1oBk1isji8NOEqtcoGSfbA3w=w408-h300-k-no", 3, 57, 11, "Kopa Guest House", "", 4.5999999999999996, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.15938 123.64315)"), null },
                    { 4, null, new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), null, "", "https://lh5.googleusercontent.com/p/AF1QipMNBX2VCsU4lifj229ibEGPfwcndMMNgYbnf-8I=w426-h240-k-no", 9, 113, 8, "Satria Homestay", "0821-4030-1904", 4.5999999999999996, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16343 123.65602)"), null },
                    { 5, new TimeOnly(22, 50, 0), new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), new TimeOnly(0, 1, 0), "", "https://lh5.googleusercontent.com/p/AF1QipOyf0j7ekNyOltMx9MHraTx4r4nEfspzoKKbPjE=w408-h306-k-no", 9, 48, 8, "Homestay Karo Bobe", "082144728877", 4.5999999999999996, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16394 123.66803)"), null },
                    { 6, new TimeOnly(13, 0, 0), new TimeOnly(12, 0, 0), new TimeOnly(13, 0, 0), new TimeOnly(12, 0, 0), "", "https://lh5.googleusercontent.com/p/AF1QipPuGkVeCoAZfMRvKrll4vklYu4EPDOoIOgkxO62=w408-h306-k-no", 1, 442, 10, "OCD Beach Cafe & Hostel", "0852-3915-9401", 4.4000000000000004, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.13221 123.66984)"), null },
                    { 7, new TimeOnly(16, 0, 0), new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), null, "", "https://lh5.googleusercontent.com/p/AF1QipNL8aQ8qSY4rhlR64GKmJt2g0k3uoIGa98X65nv=w408-h272-k-no", 3, 57, 9, "RedDoorz Near Mangrove Forest", "(021) 80629666", 4.2000000000000002, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.14905 123.64554)"), "https://www.reddoorz.com/" },
                    { 8, null, new TimeOnly(12, 0, 0), new TimeOnly(14, 0, 0), null, "", "https://lh5.googleusercontent.com/p/AF1QipOZf4kCDzYRdghaDnA4fe8MO4QbzOJImTZuHzUP=w426-h240-k-no", 17, 9, 8, "Mai Mai Homestay", "(021) 80629666", 4.4000000000000004, (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.18846 123.61535)"), null }
                });

            migrationBuilder.InsertData(
                table: "TblLokasiPenting",
                columns: new[] { "Id", "KategoriLokasiPenting", "Nama", "TitikKoordinat" },
                values: new object[,]
                {
                    { 1, 0, "Bandar Udara Internasional El Tari", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16846 123.6679)") },
                    { 2, 5, "Nasipanaf", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.18067 123.67391)") },
                    { 3, 7, "Lacaza Coffee & Homestay", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16218 123.65694)") },
                    { 4, 8, "Rumah Sakit Jiwa \"RSJ\" Naimata - Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.17875 123.63906)") },
                    { 5, 3, "Beer & Barrel Kitchen n’Lounge", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.14989 123.60397)") },
                    { 6, 9, "Salon Eleanor", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.155096345033012 123.64263013615513)") },
                    { 7, 10, "Lippo Plaza Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.158797785189762 123.61120806684349)") },
                    { 8, 10, "Toko Surya Mas", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.154731547073125 123.63101603645133)") },
                    { 9, 10, "Toko Miafa Fashion & Shoes", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.14504152615265 123.65515889382712)") },
                    { 10, 10, "TIARA SUPERMARKET NGAWI", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-7.428149456794754 111.44027486681163)") },
                    { 11, 8, "Apotik Tiara", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.15619817736691 123.65509376684349)") },
                    { 12, 11, "GMIT Jemaat Moria Liliba", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.167341245894558 123.65167980917163)") },
                    { 13, 11, "Gereja Katolik Stasi Yesus Maria Yosef GMIT Jemaat Moria Liliba", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.163788224772084 123.6456486243272)") },
                    { 14, 12, "Taman Adipura", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16380934571496 123.64565935316323)") },
                    { 15, 6, "Universitas Nusa Cendana", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.152699366087724 123.65829785425603)") },
                    { 16, 4, "Monumen Tunas Kelapa ", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.151246559346196 123.65984990898286)") },
                    { 17, 3, "Dapur Nekamese", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.165560223371887 123.65692905501547)") },
                    { 18, 8, "RSU. Mamami", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.153436634299652 123.60905405396625)") },
                    { 19, 4, "Alun-Alun Kota Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.14858481926448 123.61006343781891)") },
                    { 20, 4, "Pantai Warna Kota Kupang NTT", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.142297333458645 123.65380353781883)") },
                    { 21, 11, "Masjid Al Fatah", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.160191538785286 123.5828728819992)") },
                    { 22, 3, "La Moringa Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.17437418183125 123.61804103862426)") },
                    { 23, 8, "RSUD Prof. Dr. W Z Johannes Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.168073482596304 123.58570260898844)") },
                    { 24, 10, "Toko Utama Karya", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.156178314225947 123.62437612883605)") },
                    { 25, 10, "Matahari Department Store Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.157911990050708 123.61104298650814)") },
                    { 26, 1, "Global Sport", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.178603640220404 123.61893323068838)") },
                    { 27, 3, "Solaria - Transmart Carrefour Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.170114897390764 123.60853995952444)") },
                    { 28, 8, "Rumah Sakit Wirasakti", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.166203375321446 123.58338487116394)") },
                    { 29, 1, "Stadion Merdeka", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.160573767776516 123.58950063030237)") },
                    { 30, 10, "Transmart Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.170046435805768 123.60911297301628)") },
                    { 31, 10, "Kharisma Stationery Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.169480654673883 123.6062982558198)") },
                    { 32, 10, "Ramayana Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.173755599772544 123.61301958560706)") },
                    { 33, 6, "POLTEKKKES KEMENKES KUPANG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.158172375407423 123.6396026423279)") },
                    { 34, 8, "RSU LEONA", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.170704857825687 123.62746611349189)") },
                    { 35, 8, "Siloam Hospitals Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.157267514513673 123.61045065952203)") },
                    { 36, 6, "Universitas Muhammadiyah Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.162443506832757 123.62013012170553)") },
                    { 37, 6, "Universitas Katolik Widya Mandira", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.15985435160967 123.5875447799001)") },
                    { 38, 6, "Universitas Katolik Widya Mandira", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.15985435160967 123.5875447799001)") },
                    { 39, 1, "Stadion Oepoi Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.175571279105565 123.61709251999608)") },
                    { 40, 11, "Masjid Nurul Wathan", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.173093317895201 123.59498006455591)") },
                    { 41, 11, "GMIT Jemaat Koinonia Kuanino", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.171496317208604 123.59019342090117)") },
                    { 42, 12, "Taman TAGEPE (Taman Generasi Penerus )", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.149518820274524 123.62414809657113)") },
                    { 43, 12, "Taman Ina Bo'i", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.151117152372697 123.60838003456588)") },
                    { 44, 4, "Pantai Paradiso", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.140874244894492 123.62691141664712)") },
                    { 45, 6, "UNIVERSITAS KARYADARMA KUPANG", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.18226634155387 123.59561464418024)") },
                    { 46, 12, "Taman Kota Fontein", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.163674464657998 123.58188383280957)") },
                    { 47, 2, "Pelabuhan Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.192631229586887 123.52449042537158)") },
                    { 48, 4, "Batu Kapala Beach", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.164666670052334 123.57056615383524)") },
                    { 49, 10, "Flobamora Mall", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.174087584077462 123.6130504310108)") },
                    { 50, 11, "Masjid Nurul Iman Oebobo", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.16977477539389 123.60293285158959)") },
                    { 51, 5, "Sekolah Menengah Kejuruan Negeri 3 Kupang", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.153117835061147 123.6182331627036)") },
                    { 52, 12, "Taman Nostalgia", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.159171290674566 123.61594032831051)") },
                    { 53, 5, "Gedung Pramuka", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=0;POINT (-10.151585630398712 123.66028788783497)") }
                });

            migrationBuilder.InsertData(
                table: "TblTipeKamar",
                columns: new[] { "Id", "Nama" },
                values: new object[,]
                {
                    { 1, "Standard" },
                    { 2, "Superior" },
                    { 3, "Deluxe" },
                    { 4, "Premium" },
                    { 5, "Twin Room" },
                    { 6, "Family Room" }
                });

            migrationBuilder.InsertData(
                table: "FasilitasHotel",
                columns: new[] { "FasilitasId", "HotelId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 8 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 1 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 3 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "TblAlamat",
                columns: new[] { "Id", "Jalan", "Kecamatan", "Kelurahan", "KodePos" },
                values: new object[,]
                {
                    { 1, "Jl. Antonov", "Taebenu", "Baumata Barat", "85361" },
                    { 2, "Ladang Mas Mini Market", "Kelapa Lima", "Liliba", "85111" },
                    { 3, "Jl. Bumi 1 gang 3", "Kelapa Lima", "Liliba", "85111" },
                    { 4, "Jl. Libra No.4", "Kelapa Lima", "Liliba", "85111" },
                    { 5, "", "Kupang Tengah", "Penfui", "85148" },
                    { 6, "Jl. Terusan Timor Raya", "Kelapa Lima", "Lasiana", "85228" },
                    { 7, "Jl. Terusan Timor Raya No.KM.8", "Kelapa Lima", "Oesapa", "85228" },
                    { 8, "Jl. Siwalan No.2", "Maulafa", "Maulafa", "85142" }
                });

            migrationBuilder.InsertData(
                table: "TblHargaKamarHotel",
                columns: new[] { "IdHotel", "IdTipeKamar", "HargaKamar" },
                values: new object[,]
                {
                    { 1, 2, 280561.0 },
                    { 1, 3, 362211.0 },
                    { 1, 4, 403021.0 },
                    { 2, 2, 100000.0 },
                    { 3, 1, 182182.0 },
                    { 5, 1, 133869.0 },
                    { 7, 5, 125382.0 },
                    { 7, 6, 134338.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FasilitasHotel_HotelId",
                table: "FasilitasHotel",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_TblHargaKamarHotel_IdTipeKamar",
                table: "TblHargaKamarHotel",
                column: "IdTipeKamar");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FasilitasHotel");

            migrationBuilder.DropTable(
                name: "TblAlamat");

            migrationBuilder.DropTable(
                name: "TblHargaKamarHotel");

            migrationBuilder.DropTable(
                name: "TblLokasiPenting");

            migrationBuilder.DropTable(
                name: "TblFasilitas");

            migrationBuilder.DropTable(
                name: "TblHotel");

            migrationBuilder.DropTable(
                name: "TblTipeKamar");
        }
    }
}