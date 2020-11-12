using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "data_Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_Resource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "data_Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "data_Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    Name = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    SeriesTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_data_Category_data_Series_SeriesTypeId",
                        column: x => x.SeriesTypeId,
                        principalTable: "data_Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vod_BasicInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    CategoryTypeId = table.Column<int>(nullable: false),
                    CategoryTypeNames = table.Column<string>(nullable: true),
                    SeriesTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    En = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    Describes = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Dierctor = table.Column<string>(nullable: true),
                    Actor = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vod_BasicInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "data_Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vod_PlayInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    BasicInfoId = table.Column<int>(nullable: false),
                    ResourceId = table.Column<int>(nullable: false),
                    VodId = table.Column<int>(nullable: false),
                    Kuyun = table.Column<string>(nullable: true),
                    M3u8 = table.Column<string>(nullable: true),
                    Mp4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vod_PlayInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                        column: x => x.BasicInfoId,
                        principalTable: "Vod_BasicInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vod_PlayInfo_data_Resource_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "data_Resource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "data_Series",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "电影" },
                    { 2, "电视剧" },
                    { 3, "综艺" },
                    { 4, "动画" }
                });

            migrationBuilder.InsertData(
                table: "data_Category",
                columns: new[] { "Id", "Icon", "Name", "SeriesTypeId" },
                values: new object[,]
                {
                    { 6, null, "动作片", 1 },
                    { 31, null, "欧美动漫", 4 },
                    { 30, null, "日韩动漫", 4 },
                    { 29, null, "国产动漫", 4 },
                    { 28, null, "欧美综艺", 3 },
                    { 27, null, "日韩综艺", 3 },
                    { 26, null, "港台综艺", 3 },
                    { 25, null, "大陆综艺", 3 },
                    { 23, null, "日剧", 2 },
                    { 22, null, "台湾剧", 2 },
                    { 21, null, "微电影", 2 },
                    { 20, null, "纪录片", 2 },
                    { 16, null, "欧美剧", 2 },
                    { 15, null, "韩剧", 2 },
                    { 14, null, "港剧", 2 },
                    { 13, null, "国产剧", 2 },
                    { 12, null, "战争片", 1 },
                    { 11, null, "剧情片", 1 },
                    { 10, null, "恐怖片", 1 },
                    { 9, null, "科幻片", 1 },
                    { 8, null, "爱情片", 1 },
                    { 7, null, "喜剧", 1 },
                    { 32, null, "港台动漫", 4 },
                    { 33, null, "其他", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_data_Category_SeriesTypeId",
                table: "data_Category",
                column: "SeriesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_CategoryTypeId",
                table: "Vod_BasicInfo",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_PlayInfo_BasicInfoId",
                table: "Vod_PlayInfo",
                column: "BasicInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_PlayInfo_ResourceId",
                table: "Vod_PlayInfo",
                column: "ResourceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vod_PlayInfo");

            migrationBuilder.DropTable(
                name: "Vod_BasicInfo");

            migrationBuilder.DropTable(
                name: "data_Resource");

            migrationBuilder.DropTable(
                name: "data_Category");

            migrationBuilder.DropTable(
                name: "data_Series");
        }
    }
}
