using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierSaveDraftValidationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionSpecAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionDrawingAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DropColumn(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DrawingNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DrawingRevisionNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.AlterColumn<int>(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlanAdminCertification",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "WorkCellId",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PartInspectionDrawing",
                columns: table => new
                {
                    PartInspectionDrawingId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    DrawingNumber = table.Column<string>(nullable: true),
                    DrawingRevisionNumber = table.Column<string>(nullable: true),
                    DrawingDescription = table.Column<string>(nullable: true),
                    SubmittedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionDrawing", x => x.PartInspectionDrawingId);
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawing_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawing_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawing_SAPPartInspectionPlan_SAPPartInspecti~",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawing_User_SubmittedByUserId",
                        column: x => x.SubmittedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartInspectionSpecification",
                columns: table => new
                {
                    PartInspectionSpecificationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    SpecRevisionNumber = table.Column<string>(nullable: true),
                    SpecNumber = table.Column<string>(nullable: true),
                    SpecDescription = table.Column<string>(nullable: true),
                    SubmittedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionSpecification", x => x.PartInspectionSpecificationId);
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecification_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecification_SAPPartInspectionPlan_SAPPartIn~",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecification_User_SubmittedByUserId",
                        column: x => x.SubmittedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeId", "Description", "Name" },
                values: new object[] { 3, "User", "User" });

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment",
                column: "PartInspectionSpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment",
                column: "PartInspectionDrawingId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawing_CreatedBy",
                table: "PartInspectionDrawing",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawing_LastUpdatedBy",
                table: "PartInspectionDrawing",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawing_SAPPartInspectionPlanId",
                table: "PartInspectionDrawing",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawing_SubmittedByUserId",
                table: "PartInspectionDrawing",
                column: "SubmittedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecification_CreatedBy",
                table: "PartInspectionSpecification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecification_LastUpdatedBy",
                table: "PartInspectionSpecification",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecification_SAPPartInspectionPlanId",
                table: "PartInspectionSpecification",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecification_SubmittedByUserId",
                table: "PartInspectionSpecification",
                column: "SubmittedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartInspectionDrawing_PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment",
                column: "PartInspectionDrawingId",
                principalTable: "PartInspectionDrawing",
                principalColumn: "PartInspectionDrawingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartInspectionSpecification_PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment",
                column: "PartInspectionSpecificationId",
                principalTable: "PartInspectionSpecification",
                principalColumn: "PartInspectionSpecificationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartInspectionDrawing_PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PartInspectionSpecification_PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropTable(
                name: "PartInspectionDrawing");

            migrationBuilder.DropTable(
                name: "PartInspectionSpecification");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionSpecAttachment_PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionDrawingAttachment_PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DeleteData(
                table: "UserType",
                keyColumn: "UserTypeId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PartInspectionSpecificationId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropColumn(
                name: "PartInspectionDrawingId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.AlterColumn<int>(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlanAdminCertification",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkCellId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrawingNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrawingRevisionNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
