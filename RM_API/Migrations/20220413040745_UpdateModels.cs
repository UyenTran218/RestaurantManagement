using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RM_API.Migrations
{
    public partial class UpdateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "CategoryId",
            //    table: "Item",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "Item",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Item",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<int>(
            //    name: "UnitId",
            //    table: "Item",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "Item",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Created",
            //    table: "Category",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.AddColumn<bool>(
            //    name: "Deleted",
            //    table: "Category",
            //    type: "tinyint(1)",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddColumn<string>(
            //    name: "ParentId",
            //    table: "Category",
            //    type: "longtext",
            //    nullable: true)
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.AddColumn<DateTime>(
            //    name: "Updated",
            //    table: "Category",
            //    type: "datetime(6)",
            //    nullable: false,
            //    defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            //migrationBuilder.CreateTable(
            //    name: "Guest",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Phone = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Guest", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "ItemImage",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Data = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ItemImage", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_ItemImage_Item_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Order",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        OrderNumber = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TotalPrice = table.Column<double>(type: "double", nullable: false),
            //        PaidAmount = table.Column<double>(type: "double", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Order", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Role",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Role", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Status",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Status", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "UnitType",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UnitType", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "OrderItem",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        Voided = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        SalePrice = table.Column<double>(type: "double", nullable: false),
            //        ItemId = table.Column<int>(type: "int", nullable: true),
            //        OrderId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_OrderItem", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Item_ItemId",
            //            column: x => x.ItemId,
            //            principalTable: "Item",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_OrderItem_Order_OrderId",
            //            column: x => x.OrderId,
            //            principalTable: "Order",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "GuestTable",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        StatusId = table.Column<int>(type: "int", nullable: true),
            //        GuestId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GuestTable", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_GuestTable_Guest_GuestId",
            //            column: x => x.GuestId,
            //            principalTable: "Guest",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_GuestTable_Status_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Status",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Unit",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Updated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        UnitTypeId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Unit", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Unit_UnitType_UnitTypeId",
            //            column: x => x.UnitTypeId,
            //            principalTable: "UnitType",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_CategoryId",
            //    table: "Item",
            //    column: "CategoryId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Item_UnitId",
            //    table: "Item",
            //    column: "UnitId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTable_GuestId",
            //    table: "GuestTable",
            //    column: "GuestId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_GuestTable_StatusId",
            //    table: "GuestTable",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ItemImage_ItemId",
            //    table: "ItemImage",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_ItemId",
            //    table: "OrderItem",
            //    column: "ItemId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_OrderItem_OrderId",
            //    table: "OrderItem",
            //    column: "OrderId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Unit_UnitTypeId",
            //    table: "Unit",
            //    column: "UnitTypeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Item_Category_CategoryId",
            //    table: "Item",
            //    column: "CategoryId",
            //    principalTable: "Category",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Item_Unit_UnitId",
            //    table: "Item",
            //    column: "UnitId",
            //    principalTable: "Unit",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Item_Category_CategoryId",
            //    table: "Item");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Item_Unit_UnitId",
            //    table: "Item");

            //migrationBuilder.DropTable(
            //    name: "GuestTable");

            //migrationBuilder.DropTable(
            //    name: "ItemImage");

            //migrationBuilder.DropTable(
            //    name: "OrderItem");

            //migrationBuilder.DropTable(
            //    name: "Role");

            //migrationBuilder.DropTable(
            //    name: "Unit");

            //migrationBuilder.DropTable(
            //    name: "Guest");

            //migrationBuilder.DropTable(
            //    name: "Status");

            //migrationBuilder.DropTable(
            //    name: "Order");

            //migrationBuilder.DropTable(
            //    name: "UnitType");

            //migrationBuilder.DropIndex(
            //    name: "IX_Item_CategoryId",
            //    table: "Item");

            //migrationBuilder.DropIndex(
            //    name: "IX_Item_UnitId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "CategoryId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Deleted",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "UnitId",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "Item");

            //migrationBuilder.DropColumn(
            //    name: "Created",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "Deleted",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "ParentId",
            //    table: "Category");

            //migrationBuilder.DropColumn(
            //    name: "Updated",
            //    table: "Category");
        }
    }
}
