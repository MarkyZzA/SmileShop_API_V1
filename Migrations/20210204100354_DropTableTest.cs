using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class DropTableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("385de289-0d02-48fa-822c-a2c9413b8d81"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4cbd8a3d-bcf6-4e05-a25b-b2e99ebb7216"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5cc2f0bb-3735-4806-b9fe-6069f1f4c750"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("c1966abd-280d-48c1-a1c7-afb8a2829e21"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("534117a2-54ef-4b50-a642-8ceca526cdd5"), "user" },
                    { new Guid("fd02be6c-1bf3-4430-b8cc-b2cff5d8568e"), "Manager" },
                    { new Guid("5deea541-1db0-4b29-bf75-8bef1c8f8548"), "Admin" },
                    { new Guid("05e04941-8dc4-43a6-8338-c19a3aab2571"), "Developer" }
                });

            migrationBuilder.DropTable(
            name: "DropTest",
            schema: "shop");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("05e04941-8dc4-43a6-8338-c19a3aab2571"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("534117a2-54ef-4b50-a642-8ceca526cdd5"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("5deea541-1db0-4b29-bf75-8bef1c8f8548"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fd02be6c-1bf3-4430-b8cc-b2cff5d8568e"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4cbd8a3d-bcf6-4e05-a25b-b2e99ebb7216"), "user" },
                    { new Guid("385de289-0d02-48fa-822c-a2c9413b8d81"), "Manager" },
                    { new Guid("c1966abd-280d-48c1-a1c7-afb8a2829e21"), "Admin" },
                    { new Guid("5cc2f0bb-3735-4806-b9fe-6069f1f4c750"), "Developer" }
                });
        }
    }
}
