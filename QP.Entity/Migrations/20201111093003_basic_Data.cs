using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class basic_Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "data_Category",
                columns: new[] { "Id", "Icon", "Name", "SeriesTypeId" },
                values: new object[,]
                {
                    { 7, null, "喜剧", 1 },
                    { 31, null, "欧美动漫", 4 },
                    { 30, null, "日韩动漫", 4 },
                    { 29, null, "国产动漫", 4 },
                    { 28, null, "欧美综艺", 3 },
                    { 27, null, "日韩综艺", 3 },
                    { 26, null, "港台综艺", 3 },
                    { 25, null, "大陆综艺", 3 },
                    { 23, null, "日剧", 2 },
                    { 22, null, "台湾剧", 2 },
                    { 32, null, "港台动漫", 4 },
                    { 21, null, "微电影", 2 },
                    { 16, null, "欧美剧", 2 },
                    { 15, null, "韩剧", 2 },
                    { 14, null, "港剧", 2 },
                    { 13, null, "国产剧", 2 },
                    { 12, null, "战争片", 1 },
                    { 11, null, "剧情片", 1 },
                    { 10, null, "恐怖片", 1 },
                    { 9, null, "科幻片", 1 },
                    { 8, null, "爱情片", 1 },
                    { 20, null, "纪录片", 2 },
                    { 33, null, "其他", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33);
        }
    }
}
