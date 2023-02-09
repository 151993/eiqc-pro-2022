using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPartInspectionSaveSubmitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ApproveRejectedDate",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<int>(
                name: "ApproveRejectedId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssignToUserId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateTypeId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubmittedByUserId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SubmittedDate",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateTable(
                name: "SAPPartInspectionPlanSamplingPlan",
                columns: table => new
                {
                    SAPPartInspectionPlanSamplingPlanId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    MstrChar = table.Column<string>(nullable: true),
                    SmplProc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPPartInspectionPlanSamplingPlan", x => x.SAPPartInspectionPlanSamplingPlanId);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanSamplingPlan_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanSamplingPlan_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanSamplingPlan_SAPPartInspectionPlanSamplingPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SAPPartInspectionPlanSupplier",
                columns: table => new
                {
                    SAPPartInspectionPlanSupplierId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPPartInspectionPlanSupplier", x => x.SAPPartInspectionPlanSupplierId);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanSupplier_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlanSupplier_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanSupplierId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StateType",
                columns: table => new
                {
                    StateTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateType", x => x.StateTypeId);
                });

            migrationBuilder.InsertData(
                table: "StateType",
                columns: new[] { "StateTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Draft", "Draft" },
                    { 2, "Pending for approval", "Pending_For_Approval" },
                    { 3, "Approved", "Approved" },
                    { 4, "Rejected", "Rejected" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_ApproveRejectedId",
                table: "SAPPartInspectionPlan",
                column: "ApproveRejectedId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_AssignToUserId",
                table: "SAPPartInspectionPlan",
                column: "AssignToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_StateTypeId",
                table: "SAPPartInspectionPlan",
                column: "StateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_SubmittedByUserId",
                table: "SAPPartInspectionPlan",
                column: "SubmittedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSamplingPlan_CreatedBy",
                table: "SAPPartInspectionPlanSamplingPlan",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSamplingPlan_LastUpdatedBy",
                table: "SAPPartInspectionPlanSamplingPlan",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSamplingPlan_SAPPartInspectionPlanId",
                table: "SAPPartInspectionPlanSamplingPlan",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSupplier_CreatedBy",
                table: "SAPPartInspectionPlanSupplier",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSupplier_LastUpdatedBy",
                table: "SAPPartInspectionPlanSupplier",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlanSupplier_SAPPartInspectionPlanId",
                table: "SAPPartInspectionPlanSupplier",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_ApproveRejectedId",
                table: "SAPPartInspectionPlan",
                column: "ApproveRejectedId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_AssignToUserId",
                table: "SAPPartInspectionPlan",
                column: "AssignToUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_StateType_StateTypeId",
                table: "SAPPartInspectionPlan",
                column: "StateTypeId",
                principalTable: "StateType",
                principalColumn: "StateTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_SubmittedByUserId",
                table: "SAPPartInspectionPlan",
                column: "SubmittedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_ApproveRejectedId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_AssignToUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_StateType_StateTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_SubmittedByUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "SAPPartInspectionPlanSamplingPlan");

            migrationBuilder.DropTable(
                name: "SAPPartInspectionPlanSupplier");

            migrationBuilder.DropTable(
                name: "StateType");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_ApproveRejectedId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_AssignToUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_StateTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_SubmittedByUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ApproveRejectedDate",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ApproveRejectedId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "AssignToUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "Comment",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "StateTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SubmittedByUserId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SubmittedDate",
                table: "SAPPartInspectionPlan");
        }
    }
}
