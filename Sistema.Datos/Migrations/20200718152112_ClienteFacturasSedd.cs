using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class ClienteFacturasSedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
    name: "IX_Clientes_NumeroDocumento",
    table: "Clientes",
    column: "NumeroDocumento",
    unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_RUC",
                table: "Clientes",
                column: "RUC",
                unique: true);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "NumeroDocumento", "PrimerApellido", "PrimerNombre", "RUC", "SegundoApellido", "SegundoNombre", "TipoDocumento" },
                values: new object[,]
                {
                    { 1, "1757078579", "Marro", "Nelson", "1757078579001", null, null, "Cedula" },
                    { 2, "1757078578", "Pacheco", "Maria", "1757078579002", null, null, "Cedula" }
                });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "ArchivoFactura", "Estado", "FechaEmision", "NumeroFactura" },
                values: new object[,]
                {
                    { 1, "asd", "por pagar", new DateTime(2020, 7, 18, 10, 21, 12, 481, DateTimeKind.Local).AddTicks(4871), "001" },
                    { 2, "asd", "por pagar", new DateTime(2020, 7, 18, 10, 21, 12, 482, DateTimeKind.Local).AddTicks(5176), "002" }
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clientes_NumeroDocumento",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_RUC",
                table: "Clientes");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2);
        }
    }
}
