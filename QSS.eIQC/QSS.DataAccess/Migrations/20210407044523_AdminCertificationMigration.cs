using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class AdminCertificationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Attachment",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "LastUpdatedBy",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");


            migrationBuilder.CreateTable(
                name: "AdminCertification",
                columns: table => new
                {
                    AdminCertificationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Number = table.Column<string>(maxLength: 15, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    AssessmentBodyId = table.Column<string>(maxLength: 15, nullable: false),
                    AssessmentBodyName = table.Column<string>(maxLength: 50, nullable: false),
                    CertificateStartDate = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "((CURRENT_TIMESTAMP))"),
                    CertificateEndDate = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "((CURRENT_TIMESTAMP))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCertification", x => x.AdminCertificationId);
                    table.ForeignKey(
                        name: "FK_AdminCertification_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminCertification_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminCertificationAttachment",
                columns: table => new
                {
                    AdminCertificationAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    AdminCertificateId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminCertificationAttachment", x => x.AdminCertificationAttachmentId);
                    table.ForeignKey(
                        name: "FK_AdminCertification_AdminCertificateId",
                        column: x => x.AdminCertificateId,
                        principalTable: "AdminCertification",
                        principalColumn: "AdminCertificationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_AdminCertificationAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminCertificationAttachment_User_LastUpdatedBy",
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
                    { 390, "Admin_FormType_Can_Access", "AdminCertificationCanAccess" },
                    { 391, "Admin_FormType_Can_Create", "AdminCertificationCanCreate" },
                    { 392, "Admin_FormType_Can_Update", "AdminCertificationCanUpdate" },
                    { 393, "Admin_FormType_Can_Delete", "AdminCertificationCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId","PermissionTypeId" , "RoleId" },
                values: new object[,]
                {
                    { 780,390, 1 },
                    { 781,391, 1 },
                    { 782,392, 1 },
                    { 783,393, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertification_CreatedBy",
                table: "AdminCertification",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertification_LastUpdatedBy",
                table: "AdminCertification",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertificationAttachment_AdminCertificateId",
                table: "AdminCertificationAttachment",
                column: "AdminCertificateId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertificationAttachment_AttachmentId",
                table: "AdminCertificationAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertificationAttachment_CreatedBy",
                table: "AdminCertificationAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminCertificationAttachment_LastUpdatedBy",
                table: "AdminCertificationAttachment",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminCertificationAttachment");

            migrationBuilder.DropTable(
                name: "AdminCertification");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 783);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Attachment",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "LastUpdatedBy",
                table: "Attachment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Attachment",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Attachment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Attachment",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }
    }
}
