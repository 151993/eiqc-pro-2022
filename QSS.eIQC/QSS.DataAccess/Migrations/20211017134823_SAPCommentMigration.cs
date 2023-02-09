using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPCommentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SAPPartInspectionPlanComment",
                columns: table => new
                {
                    SAPPartInspectionPlanCommentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Comments = table.Column<string>(nullable: true),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    SubmittedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPPartInspectionPlanComment", x => x.SAPPartInspectionPlanCommentId);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanComment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanComment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanComment_SAPPartInspectionPlan_SAPPartI~",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanComment_User_SubmittedByUserId",
                        column: x => x.SubmittedByUserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 442, "Admin_SAPPartInspectionPlanComment_Can_Access", "AdminSAPPartInspectionPlanCommentCanAccess" },
                    { 443, "Admin_SAPPartInspectionPlanComment_Can_Create", "AdminSAPPartInspectionPlanCommentCanCreate" },
                    { 444, "Admin_SAPPartInspectionPlanComment_Can_Update", "AdminSAPPartInspectionPlanCommentCanUpdate" },
                    { 445, "Admin_SAPPartInspectionPlanComment_Can_Delete", "AdminSAPPartInspectionPlanCommentCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanComment_CreatedBy",
                table: "SAPPartInspectionPlanComment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanComment_LastUpdatedBy",
                table: "SAPPartInspectionPlanComment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanComment_SAPPartInspectionPlanId",
                table: "SAPPartInspectionPlanComment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanComment_SubmittedByUserId",
                table: "SAPPartInspectionPlanComment",
                column: "SubmittedByUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SAPPartInspectionPlanComment");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 445);
        }
    }
}
