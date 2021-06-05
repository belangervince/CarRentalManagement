using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class DateInNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "cea4ad8c-d847-494c-a3d0-4508e8fb5d6a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "2ee8d74c-47b9-4689-a0ae-eb7adfafbd5d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0093531c-cc97-4a64-983e-3f4b4e893ae8", "AQAAAAEAACcQAAAAEMaji8QDt1Or2To+wlbpMmNinGoe6NuGP0cUVmKpiR5SPShu+ukwqS9ITeNvmiyB7Q==", "35858d03-dced-4229-8953-14959e3624ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a58ece0-9273-4d23-b600-228804b19204", "AQAAAAEAACcQAAAAEMvyZkBFbyQWCdYf7MGO6sDx8X00U0opspyb5ecvzHB5FWT6ZgwXp9dkatPHAzfc0g==", "c49c2854-fcd6-4d31-8d00-9da00c673996" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 307, DateTimeKind.Local).AddTicks(4522), new DateTime(2021, 6, 5, 16, 36, 56, 309, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 309, DateTimeKind.Local).AddTicks(1590), new DateTime(2021, 6, 5, 16, 36, 56, 309, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1235), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1521), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1528) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1531), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1535), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1539), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1543), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1546), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4082), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4359), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4369), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4373), new DateTime(2021, 6, 5, 16, 36, 56, 310, DateTimeKind.Local).AddTicks(4375) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateIn",
                table: "Bookings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "92466019-bfa6-4522-bdf0-04dbf21fe467");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "aedbb281-7ef6-4118-b567-06c0a755ce44");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7ac13a-a66d-47af-b6e8-b613733fe3dc", "AQAAAAEAACcQAAAAEILYIRiraAUulnwnEku4cH0ExxhUYncVRIV0GCVnQYDS4BzpxgH2xFESht4Tufpk8w==", "a786012a-0741-4bcb-a568-ef5d6ee06349" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebdda91a-a44a-490d-aa87-a201aeb63918", "AQAAAAEAACcQAAAAEOsUxmyg0mYgt5icXSnT2WJrIp9B+kibfnWblLZIJ8FmDNf12vxtefHOsjmxzbR0HQ==", "02b984b2-edd6-4e45-a3f8-a6b6a96a5988" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 149, DateTimeKind.Local).AddTicks(6129), new DateTime(2021, 5, 29, 20, 14, 43, 151, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 151, DateTimeKind.Local).AddTicks(3060), new DateTime(2021, 5, 29, 20, 14, 43, 151, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2662), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2947), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2962), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2966), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2970), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2973), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5595), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5868), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5878), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5882), new DateTime(2021, 5, 29, 20, 14, 43, 152, DateTimeKind.Local).AddTicks(5884) });
        }
    }
}
