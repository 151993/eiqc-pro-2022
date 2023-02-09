using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartManufacturePartNumberMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerPartNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ManufacturerPartNumber",
                table: "Part");

            migrationBuilder.AddColumn<bool>(
                name: "IsMPNMatched",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MPNMaterialHERS",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MPNReason",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UploadedByUserId",
                table: "PartInspectionSpecAttachment",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UploadedByUserId",
                table: "PartInspectionDrawingAttachment",
                nullable: true);

     

            migrationBuilder.CreateTable(
                name: "PartInspectionCertificationAttachment",
                columns: table => new
                {
                    PartInspectionCertificationAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false),
                    UploadedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionCertificationAttachment", x => x.PartInspectionCertificationAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_PartInspectionCertificationAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionCertificationAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionCertificationAttachment_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionCertificationAttachment_User_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartManufacturePartNumber",
                columns: table => new
                {
                    PartManufacturePartNumberId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    PartId = table.Column<int>(nullable: false),
                    MPN = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartManufacturePartNumber", x => x.PartManufacturePartNumberId);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_PartId",
                        column: x => x.PartId,
                        principalTable: "Part",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PartId",
                table: "SAPPartInspectionPlan",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_UploadedByUserId",
                table: "PartInspectionSpecAttachment",
                column: "UploadedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_UploadedByUserId",
                table: "PartInspectionDrawingAttachment",
                column: "UploadedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionCertificationAttachment_AttachmentId",
                table: "PartInspectionCertificationAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionCertificationAttachment_CreatedBy",
                table: "PartInspectionCertificationAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionCertificationAttachment_LastUpdatedBy",
                table: "PartInspectionCertificationAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionCertificationAttachment_SAPPartInspectionPlan~",
                table: "PartInspectionCertificationAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionCertificationAttachment_UploadedByUserId",
                table: "PartInspectionCertificationAttachment",
                column: "UploadedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_CreatedBy",
                table: "PartManufacturePartNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_LastUpdatedBy",
                table: "PartManufacturePartNumber",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_PartId",
                table: "PartManufacturePartNumber",
                column: "PartId");


            migrationBuilder.AddForeignKey(
                name: "FK_PartInspectionDrawingAttachment_User_UploadedByUserId",
                table: "PartInspectionDrawingAttachment",
                column: "UploadedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartInspectionSpecAttachment_User_UploadedByUserId",
                table: "PartInspectionSpecAttachment",
                column: "UploadedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_Part_PartId",
                table: "SAPPartInspectionPlan",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "PartId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentId",
                table: "AdminCertificationAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PartInspectionDrawingAttachment_User_UploadedByUserId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PartInspectionSpecAttachment_User_UploadedByUserId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_Part_PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "PartInspectionCertificationAttachment");

            migrationBuilder.DropTable(
                name: "PartManufacturePartNumber");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionSpecAttachment_UploadedByUserId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionDrawingAttachment_UploadedByUserId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.DropColumn(
                name: "IsMPNMatched",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "MPNMaterialHERS",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "MPNReason",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "UploadedByUserId",
                table: "PartInspectionSpecAttachment");

            migrationBuilder.DropColumn(
                name: "UploadedByUserId",
                table: "PartInspectionDrawingAttachment");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerPartNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerPartNumber",
                table: "Part",
                type: "text",
                nullable: true);
        }
    }
}
