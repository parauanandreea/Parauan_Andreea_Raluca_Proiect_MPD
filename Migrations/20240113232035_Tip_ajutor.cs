using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class Tip_ajutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorie_Fond");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.AddColumn<int>(
                name: "Tip_ajutorID",
                table: "Proiect_MPD",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tip_ajutor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipul_ajutor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tip_ajutor", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Proiect_MPD_Tip_ajutorID",
                table: "Proiect_MPD",
                column: "Tip_ajutorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Proiect_MPD_Tip_ajutor_Tip_ajutorID",
                table: "Proiect_MPD",
                column: "Tip_ajutorID",
                principalTable: "Tip_ajutor",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proiect_MPD_Tip_ajutor_Tip_ajutorID",
                table: "Proiect_MPD");

            migrationBuilder.DropTable(
                name: "Tip_ajutor");

            migrationBuilder.DropIndex(
                name: "IX_Proiect_MPD_Tip_ajutorID",
                table: "Proiect_MPD");

            migrationBuilder.DropColumn(
                name: "Tip_ajutorID",
                table: "Proiect_MPD");

            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireCategorie = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Categorie_Fond",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorieID = table.Column<int>(type: "int", nullable: false),
                    Proiect_MPDID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie_Fond", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Categorie_Fond_Categorie_CategorieID",
                        column: x => x.CategorieID,
                        principalTable: "Categorie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Categorie_Fond_Proiect_MPD_Proiect_MPDID",
                        column: x => x.Proiect_MPDID,
                        principalTable: "Proiect_MPD",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Fond_CategorieID",
                table: "Categorie_Fond",
                column: "CategorieID");

            migrationBuilder.CreateIndex(
                name: "IX_Categorie_Fond_Proiect_MPDID",
                table: "Categorie_Fond",
                column: "Proiect_MPDID");
        }
    }
}
