using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class EstaBorrado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaBorrada",
                table: "Facturas");

            migrationBuilder.AddColumn<bool>(
                name: "EstaBorrado",
                table: "Facturas",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstaBorrado",
                table: "Facturas");

            migrationBuilder.AddColumn<bool>(
                name: "EstaBorrada",
                table: "Facturas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
