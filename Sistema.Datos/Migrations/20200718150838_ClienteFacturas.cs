using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema.Datos.Migrations
{
    public partial class ClienteFacturas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(maxLength: 150, nullable: false),
                    SegundoNombre = table.Column<string>(maxLength: 150, nullable: true),
                    PrimerApellido = table.Column<string>(maxLength: 150, nullable: false),
                    SegundoApellido = table.Column<string>(maxLength: 150, nullable: true),
                    TipoDocumento = table.Column<string>(maxLength: 20, nullable: false),
                    NumeroDocumento = table.Column<string>(maxLength: 20, nullable: false),
                    RUC = table.Column<string>(maxLength: 20, nullable: false),
                    EstaBorrado = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    FacturaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFactura = table.Column<string>(nullable: false),
                    FechaEmision = table.Column<DateTime>(nullable: false),
                    ArchivoFactura = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(maxLength: 60, nullable: true),
                    EstaBorrada = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.FacturaId);
                });

            migrationBuilder.CreateTable(
                name: "ClienteFacturas",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false),
                    FacturaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteFacturas", x => new { x.ClienteId, x.FacturaId });
                    table.ForeignKey(
                        name: "FK_ClienteFacturas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteFacturas_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "FacturaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteFacturas_FacturaId",
                table: "ClienteFacturas",
                column: "FacturaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_NumeroFactura",
                table: "Facturas",
                column: "NumeroFactura",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteFacturas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Facturas");
        }
    }
}
