using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class InitialCreateClienti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    CNP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenume_Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numar_telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carte_Luata_ImprumutID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.CNP);
                    table.ForeignKey(
                        name: "FK_Client_Carte_Carte_Luata_ImprumutID",
                        column: x => x.Carte_Luata_ImprumutID,
                        principalTable: "Carte",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_Carte_Luata_ImprumutID",
                table: "Client",
                column: "Carte_Luata_ImprumutID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
