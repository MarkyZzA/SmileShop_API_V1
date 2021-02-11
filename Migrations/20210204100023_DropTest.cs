using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class DropTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4cbd8a3d-bcf6-4e05-a25b-b2e99ebb7216"), "user" },
                    { new Guid("385de289-0d02-48fa-822c-a2c9413b8d81"), "Manager" },
                    { new Guid("c1966abd-280d-48c1-a1c7-afb8a2829e21"), "Admin" },
                    { new Guid("5cc2f0bb-3735-4806-b9fe-6069f1f4c750"), "Developer" }
                });

            migrationBuilder.CreateTable(
           name: "DropTest",
           schema: "shop",
           columns: table => new
           {
               Id = table.Column<int>(nullable: false)
                   .Annotation("SqlServer:Identity", "1, 1"),
               Name = table.Column<string>(nullable: false),
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_DropTest", x => x.Id);
           });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DropTest",
                schema: "shop");

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
                    { new Guid("8094dc9d-82b5-496b-8aa5-7419811717d9"), "user" },
                    { new Guid("a8dd6013-b4a0-4d53-9a76-6a230ffa02ec"), "Manager" },
                    { new Guid("ac5a8941-b58c-4c68-a3c6-637b2511d766"), "Admin" },
                    { new Guid("c1410937-951e-4f9d-8700-d3984696b709"), "Developer" }
                });
        }
    }
}
