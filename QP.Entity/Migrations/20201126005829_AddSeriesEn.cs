using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class AddSeriesEn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo");

            migrationBuilder.AddColumn<string>(
                name: "En",
                table: "data_Series",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6210), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6248), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6251), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6253), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6256), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6258), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6260), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6262), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6264), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6263) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6266), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6268), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6270), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6272), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6274), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6277), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6279), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6281), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6283), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6285), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6284) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6287), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6290), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6292), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6294), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6296), new DateTime(2020, 11, 26, 8, 58, 29, 41, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 38, DateTimeKind.Local).AddTicks(2124), new DateTime(2020, 11, 26, 8, 58, 29, 38, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 26, 8, 58, 29, 35, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "En", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7640), "dianshiju", new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "En", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7927), "zongyi", new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "En", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7930), "donghua", new DateTime(2020, 11, 26, 8, 58, 29, 36, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo",
                column: "BasicInfoId",
                principalTable: "Vod_BasicInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo");

            migrationBuilder.DropColumn(
                name: "En",
                table: "data_Series");

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1372) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 643, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 639, DateTimeKind.Local).AddTicks(8926) });

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
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 24, 14, 13, 23, 638, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.AddForeignKey(
                name: "FK_Vod_PlayInfo_Vod_BasicInfo_BasicInfoId",
                table: "Vod_PlayInfo",
                column: "BasicInfoId",
                principalTable: "Vod_BasicInfo",
                principalColumn: "Id");
        }
    }
}
