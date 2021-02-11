using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class fixProductGroupTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn("CreatedBy", "ProductGroup", "CreatedById", "shop");
            migrationBuilder.RenameColumn("UpdatedBy", "ProductGroup", "UpdatedById", "shop");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn("CreatedById", "ProductGroup", "CreatedBy", "shop");
            migrationBuilder.RenameColumn("UpdatedById", "ProductGroup", "UpdatedBy", "shop");

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
    }
}
