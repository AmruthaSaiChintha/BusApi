using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelLove.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Bus_BusDetailsBusId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bus",
                table: "Bus");

            migrationBuilder.RenameTable(
                name: "Bus",
                newName: "BusDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BusDetails",
                table: "BusDetails",
                column: "BusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_BusDetails_BusDetailsBusId",
                table: "Transactions",
                column: "BusDetailsBusId",
                principalTable: "BusDetails",
                principalColumn: "BusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_BusDetails_BusDetailsBusId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BusDetails",
                table: "BusDetails");

            migrationBuilder.RenameTable(
                name: "BusDetails",
                newName: "Bus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bus",
                table: "Bus",
                column: "BusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Bus_BusDetailsBusId",
                table: "Transactions",
                column: "BusDetailsBusId",
                principalTable: "Bus",
                principalColumn: "BusId");
        }
    }
}
