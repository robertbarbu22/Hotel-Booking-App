using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Booking_Platform.Migrations
{
    /// <inheritdoc />
    public partial class populatedb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeClient",
                table: "Rezervari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeHotel",
                table: "Rezervari",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeClient",
                table: "Rezervari");

            migrationBuilder.DropColumn(
                name: "NumeHotel",
                table: "Rezervari");
        }
    }
}
