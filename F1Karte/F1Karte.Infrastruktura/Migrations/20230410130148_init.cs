using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1Karte.Infrastruktura.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Karte",
                columns: table => new
                {
                    ID_Karte = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Drzava = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NazivStaze = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CenaKarte = table.Column<double>(type: "float", nullable: false),
                    BrDana = table.Column<int>(type: "int", nullable: false),
                    Tribina = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karte", x => x.ID_Karte);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karte");
        }
    }
}
