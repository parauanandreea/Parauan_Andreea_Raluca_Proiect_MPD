using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class FondStructural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proiect_MPD_Tip_ajutor_Tip_ajutorID",
                table: "Proiect_MPD");

            migrationBuilder.AlterColumn<int>(
                name: "Tip_ajutorID",
                table: "Proiect_MPD",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "Tip_ajutorID",
                table: "Proiect_MPD",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Proiect_MPD_Tip_ajutor_Tip_ajutorID",
                table: "Proiect_MPD",
                column: "Tip_ajutorID",
                principalTable: "Tip_ajutor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
