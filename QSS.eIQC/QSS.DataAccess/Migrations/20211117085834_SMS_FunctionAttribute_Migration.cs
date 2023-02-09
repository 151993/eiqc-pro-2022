using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMS_FunctionAttribute_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SupplierFunctionAttribute",
                columns: table => new
                {
                    SupplierFunctionAttributeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    ParameterManagementId = table.Column<int>(nullable: false),
                    ResultId = table.Column<int>(nullable: false),
                    IsChecked = table.Column<bool>(nullable: false),
                    IsEnabled = table.Column<bool>(nullable: false),
                    TestRequirement = table.Column<string>(nullable: true),
                    InspectionDetails = table.Column<string>(nullable: true),
                    ResultPassFailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFunctionAttribute", x => x.SupplierFunctionAttributeId);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttribute_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttribute_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttribute_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttribute_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFunctionAttributeDefectType",
                columns: table => new
                {
                    SupplierFunctionAttributeDefectTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierFunctionAttributeId = table.Column<int>(nullable: false),
                    DefectTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFunctionAttributeDefectType", x => x.SupplierFunctionAttributeDefectTypeId);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeDefectType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeDefectType_DefectTypeId",
                        column: x => x.DefectTypeId,
                        principalTable: "DefectType",
                        principalColumn: "DefectTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeDefectType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeDefectType_SupplierFunctionAttributeId",
                        column: x => x.SupplierFunctionAttributeId,
                        principalTable: "SupplierFunctionAttribute",
                        principalColumn: "SupplierFunctionAttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttribute_CreatedBy",
                table: "SupplierFunctionAttribute",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttribute_LastUpdatedBy",
                table: "SupplierFunctionAttribute",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttribute_ParameterManagementId",
                table: "SupplierFunctionAttribute",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttribute_SupplierMeasurementSubmissionId",
                table: "SupplierFunctionAttribute",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeDefectType_CreatedBy",
                table: "SupplierFunctionAttributeDefectType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeDefectType_DefectTypeId",
                table: "SupplierFunctionAttributeDefectType",
                column: "DefectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeDefectType_LastUpdatedBy",
                table: "SupplierFunctionAttributeDefectType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeDefectType_SupplierFunctionAttribu~",
                table: "SupplierFunctionAttributeDefectType",
                column: "SupplierFunctionAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropTable(
                name: "SupplierFunctionAttributeDefectType");

            migrationBuilder.DropTable(
                name: "SupplierFunctionAttribute");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "SupplierMeasurementSubmission");
        }
    }
}
