using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9394b64-77ed-4f53-8127-50cc61a5ca23", "20e27b6b-db67-48d2-8664-d20d856c1585", "User", "USER" },
                    { "a9394b64-77ed-4f53-8127-50cc61a5ca24", "f031c088-bea2-4ff9-bd28-c32188772b6b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 29, DateTimeKind.Local).AddTicks(2987), new DateTime(2021, 5, 29, 20, 1, 58, 30, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 31, DateTimeKind.Local).AddTicks(584), new DateTime(2021, 5, 29, 20, 1, 58, 31, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(420), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(713), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(721) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(724), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(728), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(732), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(736), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(739), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3358), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3635), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3646), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3650), new DateTime(2021, 5, 29, 20, 1, 58, 32, DateTimeKind.Local).AddTicks(3652) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 751, DateTimeKind.Local).AddTicks(1981), new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(9425), new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9307), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9604), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9615), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9619), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9623), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9627), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9631), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2194), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2487), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2491), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2493) });
        }
    }
}
