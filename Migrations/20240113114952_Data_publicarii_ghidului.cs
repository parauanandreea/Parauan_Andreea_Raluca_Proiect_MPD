using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    public partial class Data_publicarii_ghidului : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data_publicarii_ghidului",
                table: "Proiect_MPD",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data_publicarii_ghidului",
                table: "Proiect_MPD");
        }
    }
}
