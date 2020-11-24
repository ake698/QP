using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class AllHasFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "data_message");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "data_Series",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "data_Series",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "data_Resource",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "data_Resource",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "data_Category",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "data_Category",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "data_message",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "data_message",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "data_message",
                type: "datetime",
                maxLength: 0,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_data_message",
                table: "data_message",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 639, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 637, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5924));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_data_message",
                table: "data_message");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "data_Series");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "data_Series");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "data_Resource");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "data_Resource");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "data_Category");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "data_Category");

            migrationBuilder.RenameTable(
                name: "data_message",
                newName: "Messages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModificationTime",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldMaxLength: 0);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDelete",
                table: "Messages",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationTime",
                table: "Messages",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldMaxLength: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");
        }
    }
}
