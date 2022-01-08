using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class InitialCreateBibliotecar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BibliotecarCNP",
                table: "Carte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bibliotecar",
                columns: table => new
                {
                    CNP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Bibliotecar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume_Bibliotecar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numar_telefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecar", x => x.CNP);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carte_BibliotecarCNP",
                table: "Carte",
                column: "BibliotecarCNP");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Bibliotecar_BibliotecarCNP",
                table: "Carte",
                column: "BibliotecarCNP",
                principalTable: "Bibliotecar",
                principalColumn: "CNP",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Bibliotecar_BibliotecarCNP",
                table: "Carte");

            migrationBuilder.DropTable(
                name: "Bibliotecar");

            migrationBuilder.DropIndex(
                name: "IX_Carte_BibliotecarCNP",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "BibliotecarCNP",
                table: "Carte");
        }
    }
}
