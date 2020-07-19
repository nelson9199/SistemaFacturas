using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class QuitarSeedFact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facturas",
                keyColumn: "FacturaId",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "ArchivoFactura", "Estado", "FechaEmision", "NumeroFactura" },
                values: new object[] { 1, "asd", "por pagar", new DateTime(2020, 7, 18, 10, 21, 12, 481, DateTimeKind.Local).AddTicks(4871), "001" });

            migrationBuilder.InsertData(
                table: "Facturas",
                columns: new[] { "FacturaId", "ArchivoFactura", "Estado", "FechaEmision", "NumeroFactura" },
                values: new object[] { 2, "asd", "por pagar", new DateTime(2020, 7, 18, 10, 21, 12, 482, DateTimeKind.Local).AddTicks(5176), "002" });
        }
    }
}
