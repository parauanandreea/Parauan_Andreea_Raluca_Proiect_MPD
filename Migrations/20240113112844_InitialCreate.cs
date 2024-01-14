using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proiect_MPD",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titlu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cod_apel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip_apel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regiunea_de_dezvoltare = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proiect_MPD", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proiect_MPD");
        }
    }
}
