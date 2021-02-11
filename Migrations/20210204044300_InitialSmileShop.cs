using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmileShop_API_V1.Migrations
{
    public partial class InitialSmileShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("531e713a-f058-4797-94d5-f16285f30502"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("57e0bf9f-4625-4e39-a35a-a29d6bf7c910"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("62bfb6f0-98b7-43ec-a1ec-0db49dbbad03"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f5d39aee-3f36-4436-9aba-ec42628928f1"));

            migrationBuilder.EnsureSchema(
                name: "shop");

            migrationBuilder.CreateTable(
                name: "Order",
                schema: "shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCount = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Net = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductGroup",
                schema: "shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductGroupStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ProductGroupId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ProductStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductGroup_ProductGroupId",
                        column: x => x.ProductGroupId,
                        principalSchema: "shop",
                        principalTable: "ProductGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                schema: "shop",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Total = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    Net = table.Column<decimal>(type: "decimal(16,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "shop",
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "shop",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                schema: "shop",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                schema: "shop",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGroupId",
                schema: "shop",
                table: "Product",
                column: "ProductGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "Order",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "shop");

            migrationBuilder.DropTable(
                name: "ProductGroup",
                schema: "shop");

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

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("57e0bf9f-4625-4e39-a35a-a29d6bf7c910"), "user" },
                    { new Guid("f5d39aee-3f36-4436-9aba-ec42628928f1"), "Manager" },
                    { new Guid("531e713a-f058-4797-94d5-f16285f30502"), "Admin" },
                    { new Guid("62bfb6f0-98b7-43ec-a1ec-0db49dbbad03"), "Developer" }
                });
        }
    }
}
