using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SistemaDeVenta.Migrations
{
    public partial class addVentas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Ventas",
              columns: table => new
              {
                  id = table.Column<int>(nullable: false)
                      .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                  CorreoCliente = table.Column<string>(nullable: true),
                  Precio = table.Column<float>(nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Ventas", x => x.id);
              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
