using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPSupplierModel_ID = table.Column<string>(maxLength: 50, nullable: false),
                    SiteName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    PhoneNo = table.Column<string>(maxLength: 50, nullable: true),
                    FaxNo = table.Column<string>(maxLength: 50, nullable: true),
                    VendorCode = table.Column<string>(maxLength: 50, nullable: false),
                    VendorName = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: true),
                    StreetNo = table.Column<string>(maxLength: 100, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 50, nullable: true),
                    Country = table.Column<string>(maxLength: 50, nullable: true),
                    SupplierStatus = table.Column<string>(maxLength: 50, nullable: true),
                    SearchTerm = table.Column<string>(maxLength: 50, nullable: true),
                    ChangedOn = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                    table.ForeignKey(
                        name: "FK_Supplier_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supplier_User_LastUpdatedBy",
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
                    { 434, "Admin_Supplier_Can_Access", "AdminSupplierCanAccess" },
                    { 435, "Admin_Supplier_Can_Create", "AdminSupplierCanCreate" },
                    { 436, "Admin_Supplier_Can_Update", "AdminSupplierCanUpdate" },
                    { 437, "Admin_CommodityCategory_Can_Delete", "AdminSupplierCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "SAPDataSyncDetails",
                columns: new[] { "SAPDataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[] { 4, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "4" });

            migrationBuilder.InsertData(
                table: "SyncSAPDataType",
                columns: new[] { "SyncSAPDataTypeId", "Description", "Name" },
                values: new object[] { 4, "Last-Sync-Supplier", "Last_Sync_Supplier" });

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_CreatedBy",
                table: "Supplier",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Supplier_LastUpdatedBy",
                table: "Supplier",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "SAPDataSyncDetails",
                keyColumn: "SAPDataSyncDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 4);
        }
    }
}
