using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedValidationsToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaxId",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
