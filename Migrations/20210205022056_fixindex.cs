using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class fixindex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("8527cbe2-2bd3-4b18-9a0f-22b1bfec68b4"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9cfde0d7-af03-4fa6-be97-1d0689930468"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b9f0db40-b010-4afd-90fe-922ffab4a573"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("d66428f8-75ea-40e7-9604-e71e42c540ef"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0caf779c-4663-4ca7-8a00-c5e40240f6d3"), "user" },
                    { new Guid("a0877fe8-4db7-4782-8c30-41b87ef5715e"), "Manager" },
                    { new Guid("e2d37db4-5d70-4769-ba7d-e4f9f5c9a679"), "Admin" },
                    { new Guid("e1068ff4-2cf6-425c-bf3b-d1137f764c31"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0caf779c-4663-4ca7-8a00-c5e40240f6d3"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a0877fe8-4db7-4782-8c30-41b87ef5715e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e1068ff4-2cf6-425c-bf3b-d1137f764c31"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e2d37db4-5d70-4769-ba7d-e4f9f5c9a679"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b9f0db40-b010-4afd-90fe-922ffab4a573"), "user" },
                    { new Guid("d66428f8-75ea-40e7-9604-e71e42c540ef"), "Manager" },
                    { new Guid("9cfde0d7-af03-4fa6-be97-1d0689930468"), "Admin" },
                    { new Guid("8527cbe2-2bd3-4b18-9a0f-22b1bfec68b4"), "Developer" }
                });
        }
    }
}
