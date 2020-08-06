using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class RemoveUniqueIndexNumFac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Facturas_NumeroFactura",
                table: "Facturas");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroFactura",
                table: "Facturas",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaEmision",
                value: new DateTime(2020, 8, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroFactura",
                table: "Facturas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1,
                column: "Estado",
                value: "inactivo");

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2,
                column: "Estado",
                value: "inactivo");

            migrationBuilder.UpdateData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1,
                column: "FechaEmision",
                value: new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 1,
                column: "Estado",
                value: "inactivo");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolId",
                keyValue: 2,
                column: "Estado",
                value: "inactivo");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_NumeroFactura",
                table: "Facturas",
                column: "NumeroFactura",
                unique: true);
        }
    }
}
