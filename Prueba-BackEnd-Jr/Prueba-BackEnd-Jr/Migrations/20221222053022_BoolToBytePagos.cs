using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_BackEnd_Jr.Migrations
{
    public partial class BoolToBytePagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Aplicado",
                table: "Pagos",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Aplicado",
                table: "Pagos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }
    }
}
