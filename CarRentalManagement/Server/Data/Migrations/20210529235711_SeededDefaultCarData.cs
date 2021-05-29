using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 29, 19, 57, 10, 751, DateTimeKind.Local).AddTicks(1981), new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(8636), "Black", "System" },
                    { 2, "System", new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(9425), new DateTime(2021, 5, 29, 19, 57, 10, 752, DateTimeKind.Local).AddTicks(9436), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9307), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9322), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9604), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9612), "Nissan", "System" },
                    { 3, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9615), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9617), "Ford", "System" },
                    { 4, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9619), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9621), "Hyundai", "System" },
                    { 5, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9623), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9625), "Mazda", "System" },
                    { 6, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9627), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9629), "BMW", "System" },
                    { 7, "System", new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9631), new DateTime(2021, 5, 29, 19, 57, 10, 753, DateTimeKind.Local).AddTicks(9633), "Tesla", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2194), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2207), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2477), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2485), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2487), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2489), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2491), new DateTime(2021, 5, 29, 19, 57, 10, 754, DateTimeKind.Local).AddTicks(2493), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
