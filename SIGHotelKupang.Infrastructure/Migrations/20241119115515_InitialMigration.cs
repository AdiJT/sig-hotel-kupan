using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

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
                    BatasBawahJamCheckIn = table.Column<int>(type: "integer", nullable: true),
                    BatasAtasJamCheckIn = table.Column<int>(type: "integer", nullable: true),
                    BatasBawahJamCheckOut = table.Column<int>(type: "integer", nullable: true),
                    BatasAtasJamCheckOut = table.Column<int>(type: "integer", nullable: true),
                    NomorTelepon = table.Column<string>(type: "text", nullable: false),
                    FotoHotel = table.Column<string>(type: "text", nullable: false),
                    JumlahKamar = table.Column<int>(type: "integer", nullable: false)
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
                    DaftarFasilitasId = table.Column<int>(type: "integer", nullable: false),
                    DaftarHotelId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FasilitasHotel", x => new { x.DaftarFasilitasId, x.DaftarHotelId });
                    table.ForeignKey(
                        name: "FK_FasilitasHotel_TblFasilitas_DaftarFasilitasId",
                        column: x => x.DaftarFasilitasId,
                        principalTable: "TblFasilitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FasilitasHotel_TblHotel_DaftarHotelId",
                        column: x => x.DaftarHotelId,
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
                    KodePos = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_FasilitasHotel_DaftarHotelId",
                table: "FasilitasHotel",
                column: "DaftarHotelId");

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
