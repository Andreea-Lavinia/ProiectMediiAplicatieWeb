using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class InitialCreateImprumut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Imprumut",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carte_ImprumutataID = table.Column<int>(type: "int", nullable: true),
                    AutorID = table.Column<int>(type: "int", nullable: true),
                    ClientCNP = table.Column<int>(type: "int", nullable: true),
                    Data_Retur = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imprumut", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Imprumut_Autor_AutorID",
                        column: x => x.AutorID,
                        principalTable: "Autor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imprumut_Carte_Carte_ImprumutataID",
                        column: x => x.Carte_ImprumutataID,
                        principalTable: "Carte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Imprumut_Client_ClientCNP",
                        column: x => x.ClientCNP,
                        principalTable: "Client",
                        principalColumn: "CNP",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Imprumut_AutorID",
                table: "Imprumut",
                column: "AutorID");

            migrationBuilder.CreateIndex(
                name: "IX_Imprumut_Carte_ImprumutataID",
                table: "Imprumut",
                column: "Carte_ImprumutataID");

            migrationBuilder.CreateIndex(
                name: "IX_Imprumut_ClientCNP",
                table: "Imprumut",
                column: "ClientCNP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Imprumut");
        }
    }
}
