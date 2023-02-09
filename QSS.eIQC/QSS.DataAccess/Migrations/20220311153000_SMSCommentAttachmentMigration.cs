using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSCommentAttachmentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SMSCommentAttachment",
                columns: table => new
                {
                    SMSCommentAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false),
                    UploadedByUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSCommentAttachment", x => x.SMSCommentAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_SMSCommentAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SMSCommentAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SMSCommentAttachment_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SMSCommentAttachment_User_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SMSCommentAttachment_AttachmentId",
                table: "SMSCommentAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SMSCommentAttachment_CreatedBy",
                table: "SMSCommentAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SMSCommentAttachment_LastUpdatedBy",
                table: "SMSCommentAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SMSCommentAttachment_SupplierMeasurementSubmissionId",
                table: "SMSCommentAttachment",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SMSCommentAttachment_UploadedByUserId",
                table: "SMSCommentAttachment",
                column: "UploadedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentId",
                table: "AdminCertificationAttachment");

            migrationBuilder.DropTable(
                name: "SMSCommentAttachment");
        }
    }
}
