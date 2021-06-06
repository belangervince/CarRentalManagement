using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedImageToVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Vehicles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "9c68834e-5dce-4f1f-bced-4fb47407c64e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "4afd7a45-fdb7-4e8e-8906-ebb6862bf27b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8af76ea3-825e-4452-9b35-632ae28b68b1", "AQAAAAEAACcQAAAAEPaYpOS8/b32COEzQafo9pXJuiefYY4cM4KbEcVALcPu8Ro0+ZsKv7RyoTIypeUX9w==", "f1f54d08-ab48-4075-a255-745388f5ad5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6dc7bc8-7873-4f30-a791-3904908e2c05", "AQAAAAEAACcQAAAAEOYM/OjWYnk4np4n+TzB80PinzrvxGnMNm9M/MvSJ2RfBiv0m/+jg20Q4X02tFpCYw==", "8f06170e-3ea5-4a94-b91c-652551cf0ea7" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 579, DateTimeKind.Local).AddTicks(6332), new DateTime(2021, 6, 5, 21, 32, 18, 581, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 581, DateTimeKind.Local).AddTicks(3691), new DateTime(2021, 6, 5, 21, 32, 18, 581, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3458), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3750), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3760), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3762) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3764), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3768), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3771), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3775), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6332), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6611), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6622), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6626), new DateTime(2021, 6, 5, 21, 32, 18, 582, DateTimeKind.Local).AddTicks(6627) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Vehicles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "1799a743-22ff-438b-9140-084b549ba02f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "d333b1ed-6f48-46db-9b4b-d668d85ce80c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "426c2967-4211-4fb3-b609-5faaeddde2b1", "AQAAAAEAACcQAAAAEE2adnG2AkeKZBRjdnGa5sEKQP72Tk1yTgZZNa0UDeSF1my7SJfvKGcLF1Fu+MVcQg==", "83ec8185-821c-4f46-8cf3-ee94fde2c766" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58b6fcef-4cf3-4bb7-b265-d4498a8037ae", "AQAAAAEAACcQAAAAEBgYlYrcEnvuK2fRPCGU6G5qqI58ChFQT4EuutmfhYEhgz98Ta3p9CQRD9lIbE3GPw==", "626a889f-4134-4430-a9dc-db597d863f62" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 178, DateTimeKind.Local).AddTicks(8080), new DateTime(2021, 6, 5, 17, 2, 35, 180, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 180, DateTimeKind.Local).AddTicks(5365), new DateTime(2021, 6, 5, 17, 2, 35, 180, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5053), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5384), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5395), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5399), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5402), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5406), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5408) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5410), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(7929), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8210), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8220), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8224), new DateTime(2021, 6, 5, 17, 2, 35, 181, DateTimeKind.Local).AddTicks(8226) });
        }
    }
}
