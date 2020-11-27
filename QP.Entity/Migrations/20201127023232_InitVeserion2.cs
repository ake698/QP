using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class InitVeserion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "data_message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    Content = table.Column<string>(nullable: true),
                    IsResolved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "data_Resource",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IsDelete = table.Column<bool>(nullable: false, defaultValue: false),
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
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
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    En = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
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
                    CreationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime", maxLength: 0, nullable: false),
                    Name = table.Column<string>(nullable: true),
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
                    AreaName = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false, defaultValue: 0),
                    IsHot = table.Column<bool>(nullable: false, defaultValue: false),
                    Rate = table.Column<float>(nullable: false, defaultValue: 8f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vod_BasicInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vod_BasicInfo_data_Category_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "data_Category",
                        principalColumn: "Id");
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
                table: "data_Resource",
                columns: new[] { "Id", "CreationTime", "LastModificationTime", "Link", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8515), new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(7987), "http://api.iokzy.com/", "稳定" },
                    { 1, new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8550), new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8534), "http://www.zuidazy4.net/", "高清" }
                });

            migrationBuilder.InsertData(
                table: "data_Series",
                columns: new[] { "Id", "CreationTime", "En", "Icon", "LastModificationTime", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "dianying", "icon_1.png", new DateTime(2020, 11, 27, 10, 32, 32, 560, DateTimeKind.Local).AddTicks(4895), "电影" },
                    { 2, new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4563), "dianshiju", "icon_2.png", new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4511), "电视剧" },
                    { 3, new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4868), "zongyi", "icon_3.png", new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4863), "综艺" },
                    { 4, new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4870), "donghua", "icon_4.png", new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4869), "动画" }
                });

            migrationBuilder.InsertData(
                table: "data_Category",
                columns: new[] { "Id", "CreationTime", "LastModificationTime", "Name", "SeriesTypeId" },
                values: new object[,]
                {
                    { 6, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2356), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(1667), "动作片", 1 },
                    { 31, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2441), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2440), "欧美动漫", 4 },
                    { 30, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2438), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2437), "日韩动漫", 4 },
                    { 29, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2436), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2435), "国产动漫", 4 },
                    { 28, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2434), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2433), "欧美综艺", 3 },
                    { 27, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2432), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2431), "日韩综艺", 3 },
                    { 26, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2430), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2429), "港台综艺", 3 },
                    { 25, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2427), "大陆综艺", 3 },
                    { 23, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2426), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2425), "日剧", 2 },
                    { 22, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2424), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2423), "台湾剧", 2 },
                    { 21, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2422), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2421), "微电影", 2 },
                    { 20, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2420), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2419), "纪录片", 2 },
                    { 16, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2418), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2416), "欧美剧", 2 },
                    { 15, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2415), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2414), "韩剧", 2 },
                    { 14, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2413), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2412), "港剧", 2 },
                    { 13, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2411), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2410), "国产剧", 2 },
                    { 12, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2409), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2408), "战争片", 1 },
                    { 11, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2407), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2406), "剧情片", 1 },
                    { 10, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2405), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2404), "恐怖片", 1 },
                    { 9, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2403), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2402), "科幻片", 1 },
                    { 8, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2401), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2399), "爱情片", 1 },
                    { 7, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2398), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2383), "喜剧", 1 },
                    { 32, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2444), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2442), "港台动漫", 4 },
                    { 33, new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2446), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2445), "其他", 4 }
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
                name: "data_message");

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
