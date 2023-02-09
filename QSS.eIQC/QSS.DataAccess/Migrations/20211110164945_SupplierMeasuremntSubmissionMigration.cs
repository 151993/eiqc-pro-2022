using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierMeasuremntSubmissionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierMeasurementSubmission",
                columns: table => new
                {
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    PartNo = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    WorkCellId = table.Column<int>(nullable: true),
                    SupplierContactId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    IP = table.Column<string>(maxLength: 100, nullable: false),
                    PurchaseOrderId = table.Column<int>(nullable: false),
                    Quantity = table.Column<decimal>(nullable: true),
                    BatchNo = table.Column<string>(nullable: true),
                    BatchQuantity = table.Column<decimal>(nullable: true),
                    InspectorId = table.Column<int>(nullable: false),
                    SMSStatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMeasurementSubmission", x => x.SupplierMeasurementSubmissionId);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_User_InspectorId",
                        column: x => x.InspectorId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_PurchaseOrder_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "PurchaseOrder",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_User_SupplierContactId",
                        column: x => x.SupplierContactId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementSubmission_WorkCellId",
                        column: x => x.WorkCellId,
                        principalTable: "WorkCell",
                        principalColumn: "WorkCellId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierMeasurementManufacturePartNumber",
                columns: table => new
                {
                    SMSManufacturePartNumberId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartManufacturePartNumberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMeasurementManufacturePartNumber", x => x.SMSManufacturePartNumberId);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                        column: x => x.PartManufacturePartNumberId,
                        principalTable: "PartManufacturePartNumber",
                        principalColumn: "PartManufacturePartNumberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_SupplierMeasuremen~",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 458, "Admin_SupplierMeasurementSubmission_Can_Access", "AdminSupplierMeasurementSubmissionCanAccess" },
                    { 459, "Admin_SupplierMeasurementSubmission_Can_Create", "AdminSupplierMeasurementSubmissionCanCreate" },
                    { 460, "Admin_SupplierMeasurementSubmission_Can_Update", "AdminSupplierMeasurementSubmissionCanUpdate" },
                    { 461, "Admin_SupplierMeasurementSubmission_Can_Delete", "AdminSupplierMeasurementSubmissionCanDelete" }
                });


            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_CreatedBy",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_LastUpdatedBy",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartManufacturePartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_SupplierMeasuremen~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_CreatedBy",
                table: "SupplierMeasurementSubmission",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_InspectorId",
                table: "SupplierMeasurementSubmission",
                column: "InspectorId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_LastUpdatedBy",
                table: "SupplierMeasurementSubmission",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_PurchaseOrderId",
                table: "SupplierMeasurementSubmission",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SupplierContactId",
                table: "SupplierMeasurementSubmission",
                column: "SupplierContactId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SupplierId",
                table: "SupplierMeasurementSubmission",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_WorkCellId",
                table: "SupplierMeasurementSubmission",
                column: "WorkCellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropTable(
                name: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropTable(
                name: "SupplierMeasurementSubmission");           

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 461);
        }
    }
}
