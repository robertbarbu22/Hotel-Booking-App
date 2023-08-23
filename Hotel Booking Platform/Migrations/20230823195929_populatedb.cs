using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel_Booking_Platform.Migrations
{
    /// <inheritdoc />
    public partial class populatedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nume",
                table: "Restaurante",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeHotel",
                table: "Camere",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeDepartament",
                table: "Angajati",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeHotel",
                table: "Angajati",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nume",
                table: "Restaurante");

            migrationBuilder.DropColumn(
                name: "NumeHotel",
                table: "Camere");

            migrationBuilder.DropColumn(
                name: "NumeDepartament",
                table: "Angajati");

            migrationBuilder.DropColumn(
                name: "NumeHotel",
                table: "Angajati");
        }
    }
}
