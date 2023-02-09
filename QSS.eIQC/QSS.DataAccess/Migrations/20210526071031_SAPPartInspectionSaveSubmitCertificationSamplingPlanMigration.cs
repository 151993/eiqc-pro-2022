using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPartInspectionSaveSubmitCertificationSamplingPlanMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "SubmittedDate",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "SubmittedByUserId",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "AssignToUserId",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ApproveRejectedId",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ApproveRejectedDate",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.CreateTable(
                name: "SAPPartInspectionPlanAdminCertification",
                columns: table => new
                {
                    SAPPartInspectionPlanAdminCertificationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    AdminCertificationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPPartInspectionPlanAdminCertification", x => x.SAPPartInspectionPlanAdminCertificationId);
                    table.ForeignKey(
                        name: "FK_SP_AdminCertificationId",
                        column: x => x.AdminCertificationId,
                        principalTable: "AdminCertification",
                        principalColumn: "AdminCertificationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanAdminCertification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanAdminCertification_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SP_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_DataTypeId",
                table: "SAPPartInspectionPlan",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan",
                column: "ProductLifeCycleStageId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanAdminCertification_AdminCertificationId",
                table: "SAPPartInspectionPlanAdminCertification",
                column: "AdminCertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanAdminCertification_CreatedBy",
                table: "SAPPartInspectionPlanAdminCertification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanAdminCertification_LastUpdatedBy",
                table: "SAPPartInspectionPlanAdminCertification",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanAdminCertification_SAPPartInspectionPl~",
                table: "SAPPartInspectionPlanAdminCertification",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_DataType_DataTypeId",
                table: "SAPPartInspectionPlan",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductLifeCycleStage_ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan",
                column: "ProductLifeCycleStageId",
                principalTable: "ProductLifeCycleStage",
                principalColumn: "ProductLifeCycleStageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_DataType_DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductLifeCycleStage_ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "SAPPartInspectionPlanAdminCertification");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "SubmittedDate",
                table: "SAPPartInspectionPlan",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubmittedByUserId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssignToUserId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApproveRejectedId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "ApproveRejectedDate",
                table: "SAPPartInspectionPlan",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan",
                column: "AdminCertificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan",
                column: "AdminCertificationId",
                principalTable: "AdminCertification",
                principalColumn: "AdminCertificationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
