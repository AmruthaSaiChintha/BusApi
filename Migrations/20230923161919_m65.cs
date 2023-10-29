using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelLove.Migrations
{
    public partial class m65 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SleeperSeats",
                table: "bookings",
                newName: "Sleeper");

            migrationBuilder.RenameColumn(
                name: "SecondACSeats",
                table: "bookings",
                newName: "SecondAC");

            migrationBuilder.RenameColumn(
                name: "FirstACSeats",
                table: "bookings",
                newName: "FirstAC");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sleeper",
                table: "bookings",
                newName: "SleeperSeats");

            migrationBuilder.RenameColumn(
                name: "SecondAC",
                table: "bookings",
                newName: "SecondACSeats");

            migrationBuilder.RenameColumn(
                name: "FirstAC",
                table: "bookings",
                newName: "FirstACSeats");
        }
    }
}
