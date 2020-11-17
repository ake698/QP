using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class RenameCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Vod_BasicInfo");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Vod_BasicInfo");

            migrationBuilder.AddColumn<string>(
                name: "AreaName",
                table: "Vod_BasicInfo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaName",
                table: "Vod_BasicInfo");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
