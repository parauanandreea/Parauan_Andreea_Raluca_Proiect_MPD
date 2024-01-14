using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class proiectul_depus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Proiect_depusID",
                table: "Proiect_MPD",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proiect_MPD_Proiect_depusID",
                table: "Proiect_MPD",
                column: "Proiect_depusID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proiect_MPD_Proiect_depus_Proiect_depusID",
                table: "Proiect_MPD",
                column: "Proiect_depusID",
                principalTable: "Proiect_depus",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proiect_MPD_Proiect_depus_Proiect_depusID",
                table: "Proiect_MPD");

            migrationBuilder.DropIndex(
                name: "IX_Proiect_MPD_Proiect_depusID",
                table: "Proiect_MPD");

            migrationBuilder.DropColumn(
                name: "Proiect_depusID",
                table: "Proiect_MPD");
        }
    }
}
