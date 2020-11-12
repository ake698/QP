using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { 6, null, "动作片", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
