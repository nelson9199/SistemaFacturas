using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class ClienteFacturasSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "ArchivoFactura", "Estado", "FechaEmision", "NumeroFactura" },
                values: new object[] { 1, "archivo", "Por pagar", new DateTime(2020, 7, 23, 0, 0, 0, 0, DateTimeKind.Local), "001" });

            migrationBuilder.InsertData(
                table: "ClienteFacturas",
                columns: new[] { "ClienteId", "FacturaId" },
                values: new object[] { 4, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClienteFacturas",
                keyColumns: new[] { "ClienteId", "FacturaId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1);

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
        }
    }
}
