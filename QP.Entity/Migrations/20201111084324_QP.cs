using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class QP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "data_Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    LastModificationTime = table.Column<DateTime>(nullable: false),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(nullable: false, defaultValueSql: "(getdate())"),
                    LastModificationTime = table.Column<DateTime>(nullable: false),
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

            migrationBuilder.CreateIndex(
                name: "IX_data_Category_SeriesTypeId",
                table: "data_Category",
                column: "SeriesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_CategoryTypeId",
                table: "Vod_BasicInfo",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_SeriesTypeId",
                table: "Vod_BasicInfo",
                column: "SeriesTypeId");

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
