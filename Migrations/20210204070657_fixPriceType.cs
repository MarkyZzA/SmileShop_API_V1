using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class fixPriceType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("67c3d2f7-f0f5-44c6-913a-5b7248582fc8"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("daa5029b-7a08-41f4-a075-7e7f25cb535e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("e81a52a3-d49e-4929-9379-8bcf7c47b753"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ff256a63-93c4-4829-91f1-aeaa6adb878c"));

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                schema: "shop",
                table: "Product",
                type: "decimal(16,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                schema: "shop",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,2)");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("e81a52a3-d49e-4929-9379-8bcf7c47b753"), "user" },
                    { new Guid("ff256a63-93c4-4829-91f1-aeaa6adb878c"), "Manager" },
                    { new Guid("67c3d2f7-f0f5-44c6-913a-5b7248582fc8"), "Admin" },
                    { new Guid("daa5029b-7a08-41f4-a075-7e7f25cb535e"), "Developer" }
                });
        }
    }
}
