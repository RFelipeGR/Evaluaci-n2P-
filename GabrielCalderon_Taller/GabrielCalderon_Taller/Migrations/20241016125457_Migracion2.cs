using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GabrielCalderon_Taller.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Jugador_IDEquipo",
                table: "Jugador",
                column: "IDEquipo");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_IDEstadio",
                table: "Equipo",
                column: "IDEstadio");

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Estadio_IDEstadio",
                table: "Equipo",
                column: "IDEstadio",
                principalTable: "Estadio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugador_Equipo_IDEquipo",
                table: "Jugador",
                column: "IDEquipo",
                principalTable: "Equipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Estadio_IDEstadio",
                table: "Equipo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugador_Equipo_IDEquipo",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Jugador_IDEquipo",
                table: "Jugador");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_IDEstadio",
                table: "Equipo");
        }
    }
}
