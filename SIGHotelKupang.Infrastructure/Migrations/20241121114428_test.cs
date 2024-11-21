using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIGHotelKupang.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string[]>(
                name: "Website",
                table: "TblHotel",
                type: "text[]",
                nullable: false,
                defaultValue: new string[0],
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Website",
                value: new[] { "https://www.traveloka.com/", "https://www.booking.com/", "https://www.agoda.com/", "https://www.tripadvisor.co.id/", "https://id.tiket.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Website",
                value: new[] { "https://www.agoda.com/", "https://www.tripadvisor.co.id/", "https://id.tiket.com/", "https://id.trip.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Website",
                value: new[] { "https://www.agoda.com/", "https://www.tripadvisor.co.id/", "https://www.airbnb.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Website",
                value: new[] { "https://www.traveloka.com/", "https://www.tiket.com/", "https://www.oyorooms.com/", "https://www.booking.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 5,
                column: "Website",
                value: new[] { "https://www.traveloka.com/", "https://www.trip.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 6,
                column: "Website",
                value: new string[0]);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 7,
                column: "Website",
                value: new[] { "https://www.reddoorz.com/" });

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 8,
                column: "Website",
                value: new string[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Website",
                table: "TblHotel",
                type: "text",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]");

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 3,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 5,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 6,
                column: "Website",
                value: null);

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 7,
                column: "Website",
                value: "https://www.reddoorz.com/");

            migrationBuilder.UpdateData(
                table: "TblHotel",
                keyColumn: "Id",
                keyValue: 8,
                column: "Website",
                value: null);
        }
    }
}
