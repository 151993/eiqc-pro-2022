using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierSamplingPlanMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CertificateType",
                table: "SAPPartInspectionPlanSamplingPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "SAPPartInspectionPlanSamplingPlan",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupplierSamplingPlan",
                columns: table => new
                {
                    SupplierSamplingPlanId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SMSId = table.Column<int>(nullable: false),
                    PartInspectionSamplingPlanId = table.Column<int>(nullable: false),
                    FailedQuantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSamplingPlan", x => x.SupplierSamplingPlanId);
                    table.ForeignKey(
                        name: "FK_SupplierSamplingPlan_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSamplingPlan_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSamplingPlan_SAPPartInspectionPlanSamplingPlan_Part~",
                        column: x => x.PartInspectionSamplingPlanId,
                        principalTable: "SAPPartInspectionPlanSamplingPlan",
                        principalColumn: "SAPPartInspectionPlanSamplingPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSamplingPlan_SupplierMeasurementSubmission_SMSId",
                        column: x => x.SMSId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSamplingPlan_CreatedBy",
                table: "SupplierSamplingPlan",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSamplingPlan_LastUpdatedBy",
                table: "SupplierSamplingPlan",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSamplingPlan_PartInspectionSamplingPlanId",
                table: "SupplierSamplingPlan",
                column: "PartInspectionSamplingPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSamplingPlan_SMSId",
                table: "SupplierSamplingPlan",
                column: "SMSId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierSamplingPlan");

            migrationBuilder.DropColumn(
                name: "CertificateType",
                table: "SAPPartInspectionPlanSamplingPlan");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "SAPPartInspectionPlanSamplingPlan");
        }
    }
}
