using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class fixProductGroupNameType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("044304d1-2638-429e-a49a-a1458fc0273e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6c4feb86-da95-4e10-a34d-f29ba936ca8f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("862dd0db-dd89-4850-875f-6589186cf937"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e72ca3a9-95b6-4fc6-8d19-c68159e06c5c"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "shop",
                table: "ProductGroup",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6009c834-d5e7-4db9-8e3a-56a649e3138c"), "user" },
                    { new Guid("fb854855-8d0c-4716-a12a-f92f82ee8855"), "Manager" },
                    { new Guid("bb4bc33b-dd8c-4c13-99a7-9ea7d590a1fa"), "Admin" },
                    { new Guid("706cdffd-5a3c-4956-b0de-28d269e053c0"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6009c834-d5e7-4db9-8e3a-56a649e3138c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("706cdffd-5a3c-4956-b0de-28d269e053c0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("bb4bc33b-dd8c-4c13-99a7-9ea7d590a1fa"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("fb854855-8d0c-4716-a12a-f92f82ee8855"));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                schema: "shop",
                table: "ProductGroup",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("862dd0db-dd89-4850-875f-6589186cf937"), "user" },
                    { new Guid("044304d1-2638-429e-a49a-a1458fc0273e"), "Manager" },
                    { new Guid("e72ca3a9-95b6-4fc6-8d19-c68159e06c5c"), "Admin" },
                    { new Guid("6c4feb86-da95-4e10-a34d-f29ba936ca8f"), "Developer" }
                });
        }
    }
}
