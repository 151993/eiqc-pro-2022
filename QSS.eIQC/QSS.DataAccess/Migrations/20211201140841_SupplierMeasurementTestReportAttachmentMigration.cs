using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierMeasurementTestReportAttachmentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierFormTestReport");

            migrationBuilder.DropColumn(
                name: "InspectionDetails",
                table: "PartTestReportParameter");

            migrationBuilder.CreateTable(
                name: "SupplierTestReport",
                columns: table => new
                {
                    SupplierTestReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartTestReportParameterId = table.Column<int>(nullable: false),
                    DefectTypeId = table.Column<int>(nullable: false),
                    InspectionDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTestReport", x => x.SupplierTestReportId);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_DefectType_DefectTypeId",
                        column: x => x.DefectTypeId,
                        principalTable: "DefectType",
                        principalColumn: "DefectTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_PartTestReportParameter_PartTestReportPa~",
                        column: x => x.PartTestReportParameterId,
                        principalTable: "PartTestReportParameter",
                        principalColumn: "PartTestReportParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_SupplierMeasurementSubmission_SupplierMe~",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierTestReportAttachment",
                columns: table => new
                {
                    SupplierTestReportAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierTestReportId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false),
                    UploadedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierTestReportAttachment", x => x.SupplierTestReportAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_SupplierTestReportAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReportAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReport_SupplierTestReportId",
                        column: x => x.SupplierTestReportId,
                        principalTable: "SupplierTestReport",
                        principalColumn: "SupplierTestReportId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierTestReportAttachment_User_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 142,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierTestReport_Can_Access", "AdminSupplierTestReportCanAccess" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 143,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierTestReport_Can_Create", "AdminSupplierTestReportCanCreate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 144,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierTestReport_Can_Update", "AdminSupplierTestReportCanUpdate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 145,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierTestReport_Can_Delete", "AdminSupplierTestReportCanDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReport_CreatedBy",
                table: "SupplierTestReport",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReport_DefectTypeId",
                table: "SupplierTestReport",
                column: "DefectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReport_LastUpdatedBy",
                table: "SupplierTestReport",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReport_PartTestReportParameterId",
                table: "SupplierTestReport",
                column: "PartTestReportParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReport_SupplierMeasurementSubmissionId",
                table: "SupplierTestReport",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReportAttachment_AttachmentId",
                table: "SupplierTestReportAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReportAttachment_CreatedBy",
                table: "SupplierTestReportAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReportAttachment_LastUpdatedBy",
                table: "SupplierTestReportAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReportAttachment_SupplierTestReportId",
                table: "SupplierTestReportAttachment",
                column: "SupplierTestReportId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierTestReportAttachment_UploadedByUserId",
                table: "SupplierTestReportAttachment",
                column: "UploadedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentId",
                table: "AdminCertificationAttachment");

            migrationBuilder.DropTable(
                name: "SupplierTestReportAttachment");

            migrationBuilder.DropTable(
                name: "SupplierTestReport");

            migrationBuilder.AddColumn<string>(
                name: "InspectionDetails",
                table: "PartTestReportParameter",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupplierFormTestReport",
                columns: table => new
                {
                    SupplierFormTestReportId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    ParameterName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ResultActual = table.Column<bool>(type: "boolean", nullable: false),
                    ResultExpected = table.Column<bool>(type: "boolean", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false),
                    SupplierFormId = table.Column<int>(type: "integer", nullable: false),
                    TestCondition = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormTestReport", x => x.SupplierFormTestReportId);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 142,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierFormTestReport_Can_Access", "AdminSupplierFormTestReportCanAccess" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 143,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierFormTestReport_Can_Create", "AdminSupplierFormTestReportCanCreate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 144,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierFormTestReport_Can_Update", "AdminSupplierFormTestReportCanUpdate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 145,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_SupplierFormTestReport_Can_Delete", "AdminSupplierFormTestReportCanDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_CreatedBy",
                table: "SupplierFormTestReport",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_LastUpdatedBy",
                table: "SupplierFormTestReport",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_SupplierFormId",
                table: "SupplierFormTestReport",
                column: "SupplierFormId");
        }
    }
}
