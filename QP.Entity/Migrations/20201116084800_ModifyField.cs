using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class ModifyField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Vod_BasicInfo");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Vod_BasicInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Vod_BasicInfo");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
