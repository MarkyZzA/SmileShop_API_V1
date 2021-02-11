using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class IndexAndFKeyAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1a14a4ba-d7d7-4fdf-a827-7267b40736fe"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("48457f46-8481-46a8-a910-536e99c6f281"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7d8186ef-99df-4b78-8b45-11aab28a5e3b"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b62abee8-b456-4cde-bf10-d8e097804d1b"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8094dc9d-82b5-496b-8aa5-7419811717d9"), "user" },
                    { new Guid("a8dd6013-b4a0-4d53-9a76-6a230ffa02ec"), "Manager" },
                    { new Guid("ac5a8941-b58c-4c68-a3c6-637b2511d766"), "Admin" },
                    { new Guid("c1410937-951e-4f9d-8700-d3984696b709"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8094dc9d-82b5-496b-8aa5-7419811717d9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a8dd6013-b4a0-4d53-9a76-6a230ffa02ec"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ac5a8941-b58c-4c68-a3c6-637b2511d766"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1410937-951e-4f9d-8700-d3984696b709"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7d8186ef-99df-4b78-8b45-11aab28a5e3b"), "user" },
                    { new Guid("48457f46-8481-46a8-a910-536e99c6f281"), "Manager" },
                    { new Guid("b62abee8-b456-4cde-bf10-d8e097804d1b"), "Admin" },
                    { new Guid("1a14a4ba-d7d7-4fdf-a827-7267b40736fe"), "Developer" }
                });
        }
    }
}
