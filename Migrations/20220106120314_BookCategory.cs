using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class BookCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte");

            migrationBuilder.AlterColumn<int>(
                name: "AutorID",
                table: "Carte",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Autor",
                table: "Autor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte",
                column: "AutorID",
                principalTable: "Autor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte");

            migrationBuilder.AlterColumn<int>(
                name: "AutorID",
                table: "Carte",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Nume_Autor",
                table: "Autor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Carte_Autor_AutorID",
                table: "Carte",
                column: "AutorID",
                principalTable: "Autor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
