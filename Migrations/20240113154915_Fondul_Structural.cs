using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class Fondul_Structural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fondul_StructuralID",
                table: "Proiect_MPD",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fondul_Structural",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FondulStructural = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fondul_Structural", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proiect_MPD_Fondul_StructuralID",
                table: "Proiect_MPD",
                column: "Fondul_StructuralID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proiect_MPD_Fondul_Structural_Fondul_StructuralID",
                table: "Proiect_MPD",
                column: "Fondul_StructuralID",
                principalTable: "Fondul_Structural",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proiect_MPD_Fondul_Structural_Fondul_StructuralID",
                table: "Proiect_MPD");

            migrationBuilder.DropTable(
                name: "Fondul_Structural");

            migrationBuilder.DropIndex(
                name: "IX_Proiect_MPD_Fondul_StructuralID",
                table: "Proiect_MPD");

            migrationBuilder.DropColumn(
                name: "Fondul_StructuralID",
                table: "Proiect_MPD");
        }
    }
}
