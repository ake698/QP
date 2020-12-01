using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QP.Entity.Migrations
{
    public partial class AddIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Vod_BasicInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vod_BasicInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "En",
                table: "Vod_BasicInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dierctor",
                table: "Vod_BasicInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Actor",
                table: "Vod_BasicInfo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9458), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9525), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9529), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9532), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9535), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9538), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9541), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9544), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9547), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9550), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9553), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9556), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9559), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9562), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9565), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9568), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9571), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9574), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9577), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9580), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9583), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9586), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9589), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9592), new DateTime(2020, 12, 1, 19, 58, 13, 628, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 622, DateTimeKind.Local).AddTicks(3594), new DateTime(2020, 12, 1, 19, 58, 13, 622, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 622, DateTimeKind.Local).AddTicks(3536), new DateTime(2020, 12, 1, 19, 58, 13, 622, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModificationTime",
                value: new DateTime(2020, 12, 1, 19, 58, 13, 617, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(5556), new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(6208), new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(6212), new DateTime(2020, 12, 1, 19, 58, 13, 619, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_Actor",
                table: "Vod_BasicInfo",
                column: "Actor");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_Dierctor",
                table: "Vod_BasicInfo",
                column: "Dierctor");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_En",
                table: "Vod_BasicInfo",
                column: "En");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_Name",
                table: "Vod_BasicInfo",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Vod_BasicInfo_Year",
                table: "Vod_BasicInfo",
                column: "Year");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vod_BasicInfo_Actor",
                table: "Vod_BasicInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vod_BasicInfo_Dierctor",
                table: "Vod_BasicInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vod_BasicInfo_En",
                table: "Vod_BasicInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vod_BasicInfo_Name",
                table: "Vod_BasicInfo");

            migrationBuilder.DropIndex(
                name: "IX_Vod_BasicInfo_Year",
                table: "Vod_BasicInfo");

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "En",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Dierctor",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Actor",
                table: "Vod_BasicInfo",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2356), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2398), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2401), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2403), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2405), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2407), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2409), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2411), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2413), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2415), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2418), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2420), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2422), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2424), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2426), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2428), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2430), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2432), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2434), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2436), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2438), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2441), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2444), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "data_Category",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2446), new DateTime(2020, 11, 27, 10, 32, 32, 566, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8550), new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.UpdateData(
                table: "data_Resource",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(8515), new DateTime(2020, 11, 27, 10, 32, 32, 562, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastModificationTime",
                value: new DateTime(2020, 11, 27, 10, 32, 32, 560, DateTimeKind.Local).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4563), new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4868), new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "data_Series",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreationTime", "LastModificationTime" },
                values: new object[] { new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4870), new DateTime(2020, 11, 27, 10, 32, 32, 561, DateTimeKind.Local).AddTicks(4869) });
        }
    }
}
