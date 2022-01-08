using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMediiAplicatieWeb.Migrations
{
    public partial class InitialCreateBug : Migration
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
