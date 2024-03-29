﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class EstadoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "ClienteId",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Clientes",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "activo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Clientes");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "NumeroDocumento", "PrimerApellido", "PrimerNombre", "RUC", "SegundoApellido", "SegundoNombre", "TipoDocumento" },
                values: new object[] { 1, "1757078579", "Marro", "Nelson", "1757078579001", null, null, "Cedula" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "NumeroDocumento", "PrimerApellido", "PrimerNombre", "RUC", "SegundoApellido", "SegundoNombre", "TipoDocumento" },
                values: new object[] { 2, "1757078578", "Pacheco", "Maria", "1757078579002", null, null, "Cedula" });
        }
    }
}
