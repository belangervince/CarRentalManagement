using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class Customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "a82e00af-276b-44c9-841c-f2f634b9f3e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "c5205f6a-cfa5-4249-8891-e74dd0740086");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b07f6bf-a333-4c81-9c87-318fcd0262c6", "AQAAAAEAACcQAAAAEBSCQKuIwtyIplJ1rhHvCILcM3031Xw3+sNpiA46ihYRYRhpQwJbRme/PxfldMjSZA==", "9bcc84be-8699-4e2e-8d5b-579c3ef628de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "283257ba-b299-47cb-b900-593ae95f5d35", "AQAAAAEAACcQAAAAEBD49siOKxcDOjWpH4ppxTwOTdlWrm6KANO5MaLUzGuQtWdkNrTH5fjvHrdgqBYryA==", "5c46a23e-dfc3-41a1-85a4-1b8875c22479" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 154, DateTimeKind.Local).AddTicks(8003), new DateTime(2021, 6, 5, 16, 56, 8, 156, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 156, DateTimeKind.Local).AddTicks(4982), new DateTime(2021, 6, 5, 16, 56, 8, 156, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4589), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4877), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4886), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4890), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4894), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4898), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4902), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7612), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7894), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7904), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7908), new DateTime(2021, 6, 5, 16, 56, 8, 157, DateTimeKind.Local).AddTicks(7910) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

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
    }
}
