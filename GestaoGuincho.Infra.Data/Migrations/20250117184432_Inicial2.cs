using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoGuincho.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkingId",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ParkingId",
                table: "Vehicles",
                column: "ParkingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Parkings_ParkingId",
                table: "Vehicles",
                column: "ParkingId",
                principalTable: "Parkings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Parkings_ParkingId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ParkingId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "ParkingId",
                table: "Vehicles");
        }
    }
}
