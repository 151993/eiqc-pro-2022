using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartTestReportDBSaveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartTestReportParameter_PartNo",
                table: "PartTestReportParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartTestReportParameter_PartNo",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "ParameterName",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "ResultActual",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "ResultExpected",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "TestCondition",
                table: "PartTestReportParameter");         

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "PartTestReportParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "PartTestReportParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "PartTestReportParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartTestReportParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TestReportId",
                table: "PartTestReportParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TestRequirement",
                table: "PartTestReportParameter",
                nullable: true);            

            migrationBuilder.CreateTable(
                name: "PartTestReportAttachment",
                columns: table => new
                {
                    PartTestReportAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    PartTestReportParameterId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false),
                    UploadedByUserId = table.Column<int>(nullable: true),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTestReportAttachment", x => x.PartTestReportAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_PartTestReportAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTestReportAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTestReport_PartTestReportParameterId",
                        column: x => x.PartTestReportParameterId,
                        principalTable: "PartTestReportParameter",
                        principalColumn: "PartTestReportParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTestReportAttachment_SAPPartInspectionPlan_SAPPartInspe~",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartTestReportAttachment_User_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_TestReportId",
                table: "PartTestReportParameter",
                column: "TestReportId");


            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_AttachmentId",
                table: "PartTestReportAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_CreatedBy",
                table: "PartTestReportAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_LastUpdatedBy",
                table: "PartTestReportAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_PartTestReportParameterId",
                table: "PartTestReportAttachment",
                column: "PartTestReportParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_SAPPartInspectionPlanId",
                table: "PartTestReportAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_UploadedByUserId",
                table: "PartTestReportAttachment",
                column: "UploadedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PTRParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartTestReportParameter_TestReport_TestReportId",
                table: "PartTestReportParameter",
                column: "TestReportId",
                principalTable: "TestReport",
                principalColumn: "TestReportId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_PTRParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartTestReportParameter_TestReport_TestReportId",
                table: "PartTestReportParameter");

            migrationBuilder.DropTable(
                name: "PartInspectionBowTwistParameter");

            migrationBuilder.DropTable(
                name: "PartTestReportAttachment");

            migrationBuilder.DropIndex(
                name: "IX_PartTestReportParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartTestReportParameter_TestReportId",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "TestReportId",
                table: "PartTestReportParameter");

            migrationBuilder.DropColumn(
                name: "TestRequirement",
                table: "PartTestReportParameter");


            migrationBuilder.AddColumn<string>(
                name: "ParameterName",
                table: "PartTestReportParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartTestReportParameter",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ResultActual",
                table: "PartTestReportParameter",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "ResultExpected",
                table: "PartTestReportParameter",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TestCondition",
                table: "PartTestReportParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_PartNo",
                table: "PartTestReportParameter",
                column: "PartNo");

            migrationBuilder.AddForeignKey(
                name: "FK_PartTestReportParameter_PartNo",
                table: "PartTestReportParameter",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
