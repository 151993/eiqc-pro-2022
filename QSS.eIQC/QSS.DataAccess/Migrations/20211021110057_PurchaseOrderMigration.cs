using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PurchaseOrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPPurchaseOrderId = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    PartNo = table.Column<string>(nullable: true),
                    MPNMaterial = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true),
                    PurchaseOrderNo = table.Column<string>(nullable: true),
                    PurchaseOrderLineNo = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(nullable: true),
                    VendorCode = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    ManufacturerPartNo = table.Column<string>(nullable: true),
                    PurchaseOrderStatus = table.Column<string>(nullable: true),
                    Deleted = table.Column<string>(nullable: true),
                    QuantityDelivered = table.Column<decimal>(nullable: true),
                    LastModifiedDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 446, "Admin_PurchaseOrder_Can_Access", "AdminPurchaseOrderCanAccess" },
                    { 447, "Admin_PurchaseOrder_Can_Create", "AdminPurchaseOrderCanCreate" },
                    { 448, "Admin_PurchaseOrder_Can_Update", "AdminPurchaseOrderCanUpdate" },
                    { 449, "Admin_PurchaseOrder_Can_Delete", "AdminPurchaseOrderCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "SAPDataSyncDetails",
                columns: new[] { "SAPDataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[] { 5, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "5" });

            migrationBuilder.InsertData(
                table: "SyncSAPDataType",
                columns: new[] { "SyncSAPDataTypeId", "Description", "Name" },
                values: new object[] { 5, "Last-Sync-PurchaseOrder", "Last_Sync_PurchaseOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CreatedBy",
                table: "PurchaseOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_LastUpdatedBy",
                table: "PurchaseOrder",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "SAPDataSyncDetails",
                keyColumn: "SAPDataSyncDetailsId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 5);
        }
    }
}
