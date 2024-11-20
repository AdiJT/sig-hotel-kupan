using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIGHotelKupang.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TambahRatingDiHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "TblHotel",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "TblHotel");
        }
    }
}
