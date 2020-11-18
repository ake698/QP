using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class AddFieldRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                table: "Vod_BasicInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_data_Resource_ResourceId",
                table: "Vod_PlayInfo");

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "Vod_BasicInfo",
                nullable: false,
                defaultValue: 8f);

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                table: "Vod_BasicInfo",
                column: "CategoryTypeId",
                principalTable: "data_Category",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo",
                column: "BasicInfoId",
                principalTable: "Vod_BasicInfo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_data_Resource_ResourceId",
                table: "Vod_PlayInfo",
                column: "ResourceId",
                principalTable: "data_Resource",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                table: "Vod_BasicInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_data_Resource_ResourceId",
                table: "Vod_PlayInfo");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Vod_BasicInfo");

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                table: "Vod_BasicInfo",
                column: "CategoryTypeId",
                principalTable: "data_Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo",
                column: "BasicInfoId",
                principalTable: "Vod_BasicInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_data_Resource_ResourceId",
                table: "Vod_PlayInfo",
                column: "ResourceId",
                principalTable: "data_Resource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
