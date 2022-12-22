using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_BackEnd_Jr.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    MontoSolicitado = table.Column<decimal>(type: "decimal(28,2)", precision: 28, scale: 2, nullable: false),
                    Estatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Aprobacion = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    FechaAlta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Ajustes",
                columns: table => new
                {
                    AjusteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "decimal(28,2)", precision: 28, scale: 2, nullable: true),
                    Adeudo = table.Column<decimal>(type: "decimal(28,2)", precision: 28, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ajustes", x => x.AjusteID);
                    table.ForeignKey(
                        name: "FK_Ajustes_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    MontoPagado = table.Column<decimal>(type: "decimal(28,2)", precision: 28, scale: 2, nullable: false),
                    Aplicado = table.Column<bool>(type: "bit", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoID);
                    table.ForeignKey(
                        name: "FK_Pagos_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ajustes_ClienteID",
                table: "Ajustes",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ajustes");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
