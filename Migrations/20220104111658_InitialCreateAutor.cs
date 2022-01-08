using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class InitialCreateAutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorID",
                table: "Carte",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Autor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carte_AutorID",
                table: "Carte",
                column: "AutorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte",
                column: "AutorID",
                principalTable: "Autor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropIndex(
                name: "IX_Carte_AutorID",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "AutorID",
                table: "Carte");
        }
    }
}
