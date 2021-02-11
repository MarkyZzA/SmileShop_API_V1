using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class updatebyanddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("021da00d-fd9f-4539-8c39-42a190a2d629"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a1e7078e-02fd-432e-9ad7-45d77120a627"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cdb018aa-38ba-4824-b31c-4c7135419fba"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f9caf3c5-0b3e-418f-898a-5b92d9353d83"));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                schema: "shop",
                table: "ProductGroup",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "shop",
                table: "ProductGroup",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                schema: "shop",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "shop",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                schema: "shop",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                schema: "shop",
                table: "Order",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "shop",
                table: "ProductGroup");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "shop",
                table: "ProductGroup");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "shop",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "shop",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                schema: "shop",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                schema: "shop",
                table: "Order");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("021da00d-fd9f-4539-8c39-42a190a2d629"), "user" },
                    { new Guid("cdb018aa-38ba-4824-b31c-4c7135419fba"), "Manager" },
                    { new Guid("f9caf3c5-0b3e-418f-898a-5b92d9353d83"), "Admin" },
                    { new Guid("a1e7078e-02fd-432e-9ad7-45d77120a627"), "Developer" }
                });
        }
    }
}
