using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_BackEnd_Jr.Migrations
{
    public partial class OneToOneClientesAjustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Ajustes_ClienteID",
                table: "Ajustes");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Ajustes_ClienteID",
                table: "Ajustes",
                column: "ClienteID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Ajustes_ClienteID",
                table: "Ajustes");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos",
                column: "ClienteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ajustes_ClienteID",
                table: "Ajustes",
                column: "ClienteID");
        }
    }
}
