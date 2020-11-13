using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class ModifyBasicInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "data_Category");

            migrationBuilder.AddColumn<string>(
                name: "Count",
                table: "Vod_BasicInfo",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHot",
                table: "Vod_BasicInfo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "data_Series",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "Icon",
                value: "icon_1.png");

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2,
                column: "Icon",
                value: "icon_2.png");

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                column: "Icon",
                value: "icon_3.png");

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                column: "Icon",
                value: "icon_4.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Vod_BasicInfo");

            migrationBuilder.DropColumn(
                name: "IsHot",
                table: "Vod_BasicInfo");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "data_Series");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "data_Category",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
