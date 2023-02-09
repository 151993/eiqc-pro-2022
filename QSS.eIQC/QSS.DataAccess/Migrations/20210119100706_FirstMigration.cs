using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogType",
                columns: table => new
                {
                    AuditLogTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogType", x => x.AuditLogTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionType",
                columns: table => new
                {
                    PermissionTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionType", x => x.PermissionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "StatusType",
                columns: table => new
                {
                    StatusTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusType", x => x.StatusTypeId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    UserName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    EmployeeId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AllowNotification = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                columns: table => new
                {
                    AttachmentId = table.Column<int>(nullable: false)
                    .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SavePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Attachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditLog",
                columns: table => new
                {
                    AuditLogId = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    AuditLogTypeId = table.Column<byte>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    ChangeReason = table.Column<string>(nullable: true),
                    AuditData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.AuditLogId);
                    table.ForeignKey(
                        name: "FK_AuditLog_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuditLog_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Department_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Department_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                columns: table => new
                {
                    EmailTemplateId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    Name = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.EmailTemplateId);
                    table.ForeignKey(
                        name: "FK_EmailTemplate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmailTemplate_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AuditLogType",
                columns: new[] { "AuditLogTypeId", "Description", "Name" },
                values: new object[] { 1, "Configuration", "Configuration" });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 15, "Admin_Department_Can_Delete", "AdminDepartmentCanDelete" },
                    { 14, "Admin_Department_Can_Update", "AdminDepartmentCanUpdate" },
                    { 13, "Admin_Department_Can_Create", "AdminDepartmentCanCreate" },
                    { 12, "Admin_Department_Can_Access", "AdminDepartmentCanAccess" },
                    { 11, "Admin_EmailTemplate_Can_Update", "AdminEmailTemplateCanUpdate" },
                    { 10, "Admin_EmailTemplate_Can_Access", "AdminEmailTemplateCanAccess" },
                    { 8, "Admin_User_Can_Update", "AdminUserCanUpdate" },
                    { 9, "Admin_User_Can_Delete", "AdminUserCanDelete" },
                    { 6, "Admin_User_Can_Access", "AdminUserCanAccess" },
                    { 5, "Admin_Role_Can_Delete", "AdminRoleCanDelete" },
                    { 4, "Admin_Role_Can_Update", "AdminRoleCanUpdate" },
                    { 3, "Admin_Role_Can_Create", "AdminRoleCanCreate" },
                    { 2, "Admin_Role_Can_Access", "AdminRoleCanAccess" },
                    { 1, "Admin_Can_Access", "AdminCanAccess" },
                    { 7, "Admin_User_Can_Create", "AdminUserCanCreate" }
                });

            migrationBuilder.InsertData(
                table: "StatusType",
                columns: new[] { "StatusTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Active", "Active" },
                    { 2, "Inactive", "Inactive" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "AllowNotification", "Email", "EmployeeId", "Name", "UserName" },
                values: new object[,] { { 1, false, "sandip_patil2@jabil.com", "1232922", "Sandip Patil", "1232922" },
                                        { 2, false, "alok_saste@jabil.com", "2930215", "Alok Saste", "2930215" },});

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_CreatedBy",
                table: "Attachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_LastUpdatedBy",
                table: "Attachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuditLog_CreatedBy",
                table: "AuditLog",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AuditLog_LastUpdatedBy",
                table: "AuditLog",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CreatedBy",
                table: "Department",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Department_LastUpdatedBy",
                table: "Department",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_CreatedBy",
                table: "EmailTemplate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_LastUpdatedBy",
                table: "EmailTemplate",
                column: "LastUpdatedBy");

            
            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedBy",
                table: "User",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_LastUpdatedBy",
                table: "User",
                column: "LastUpdatedBy");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachment");

            migrationBuilder.DropTable(
                name: "AuditLog");

            migrationBuilder.DropTable(
                name: "AuditLogType");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "PermissionType");

            migrationBuilder.DropTable(
                name: "StatusType");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
