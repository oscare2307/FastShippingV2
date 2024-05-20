using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pedidos.Migrations
{
    /// <inheritdoc />
    public partial class addVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VehiculoId",
                table: "Conductores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Conductores_VehiculoId",
                table: "Conductores",
                column: "VehiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Conductores_Vehiculos_VehiculoId",
                table: "Conductores",
                column: "VehiculoId",
                principalTable: "Vehiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conductores_Vehiculos_VehiculoId",
                table: "Conductores");

            migrationBuilder.DropIndex(
                name: "IX_Conductores_VehiculoId",
                table: "Conductores");

            migrationBuilder.DropColumn(
                name: "VehiculoId",
                table: "Conductores");
        }
    }
}
