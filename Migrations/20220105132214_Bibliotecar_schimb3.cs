using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class Bibliotecar_schimb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Bibliotecar_BibliotecarCNP",
                table: "Carte");

            migrationBuilder.DropIndex(
                name: "IX_Carte_BibliotecarCNP",
                table: "Carte");

            migrationBuilder.DropColumn(
                name: "BibliotecarCNP",
                table: "Carte");

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Carte",
                table: "Carte",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Carte_ImprumutataID",
                table: "Bibliotecar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bibliotecar_Carte_ImprumutataID",
                table: "Bibliotecar",
                column: "Carte_ImprumutataID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bibliotecar_Carte_Carte_ImprumutataID",
                table: "Bibliotecar",
                column: "Carte_ImprumutataID",
                principalTable: "Carte",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bibliotecar_Carte_Carte_ImprumutataID",
                table: "Bibliotecar");

            migrationBuilder.DropIndex(
                name: "IX_Bibliotecar_Carte_ImprumutataID",
                table: "Bibliotecar");

            migrationBuilder.DropColumn(
                name: "Carte_ImprumutataID",
                table: "Bibliotecar");

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Carte",
                table: "Carte",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddColumn<int>(
                name: "BibliotecarCNP",
                table: "Carte",
                type: "int",
                nullable: true);

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
    }
}
