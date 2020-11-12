using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class AddResource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "data_Resource",
                columns: new[] { "Id", "Link", "Name" },
                values: new object[] { 1, "http://api.iokzy.com/", "OK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
