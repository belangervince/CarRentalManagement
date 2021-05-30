using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b9394b64-77ed-4f53-8127-50cc61a5ca23", 0, "ebdda91a-a44a-490d-aa87-a201aeb63918", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOsUxmyg0mYgt5icXSnT2WJrIp9B+kibfnWblLZIJ8FmDNf12vxtefHOsjmxzbR0HQ==", null, false, "02b984b2-edd6-4e45-a3f8-a6b6a96a5988", false, "admin@localhost.com" },
                    { "b8394b64-77ed-4f53-8127-50cc61a5ca23", 0, "8a7ac13a-a66d-47af-b6e8-b613733fe3dc", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEILYIRiraAUulnwnEku4cH0ExxhUYncVRIV0GCVnQYDS4BzpxgH2xFESht4Tufpk8w==", null, false, "a786012a-0741-4bcb-a568-ef5d6ee06349", false, "user@localhost.com" }
                });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a9394b64-77ed-4f53-8127-50cc61a5ca24", "b9394b64-77ed-4f53-8127-50cc61a5ca23" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a9394b64-77ed-4f53-8127-50cc61a5ca23", "b8394b64-77ed-4f53-8127-50cc61a5ca23" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9394b64-77ed-4f53-8127-50cc61a5ca23", "b8394b64-77ed-4f53-8127-50cc61a5ca23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9394b64-77ed-4f53-8127-50cc61a5ca24", "b9394b64-77ed-4f53-8127-50cc61a5ca23" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8394b64-77ed-4f53-8127-50cc61a5ca23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b9394b64-77ed-4f53-8127-50cc61a5ca23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                column: "ConcurrencyStamp",
                value: "20e27b6b-db67-48d2-8664-d20d856c1585");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                column: "ConcurrencyStamp",
                value: "f031c088-bea2-4ff9-bd28-c32188772b6b");

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
    }
}
