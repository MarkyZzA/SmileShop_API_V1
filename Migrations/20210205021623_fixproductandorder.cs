using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class fixproductandorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn("CreatedBy", "Product", "CreatedById", "shop");
            migrationBuilder.RenameColumn("UpdatedBy", "Product", "UpdatedById", "shop");
            migrationBuilder.RenameColumn("CreatedBy", "Order", "CreatedById", "shop");
            migrationBuilder.RenameColumn("UpdatedBy", "Order", "UpdatedById", "shop");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_User_CreatedById",
                schema: "shop",
                table: "ProductGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductGroup_User_UpdatedById",
                schema: "shop",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_CreatedById",
                schema: "shop",
                table: "ProductGroup");

            migrationBuilder.DropIndex(
                name: "IX_ProductGroup_UpdatedById",
                schema: "shop",
                table: "ProductGroup");

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

            migrationBuilder.RenameColumn("CreatedById", "Product", "CreatedBy", "shop");
            migrationBuilder.RenameColumn("UpdatedById", "Product", "UpdatedBy", "shop");
            migrationBuilder.RenameColumn("CreatedById", "Order", "CreatedBy", "shop");
            migrationBuilder.RenameColumn("UpdatedById", "Order", "UpdatedBy", "shop");

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedBy",
                schema: "shop",
                table: "ProductGroup",
                type: "uniqueidentifier",
                nullable: true);

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
        }
    }
}
