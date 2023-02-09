using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierVisualInspection_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartCountParameter",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupplierVisualInspection",
                columns: table => new
                {
                    SupplierVisualInspectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartCountParameterId = table.Column<int>(nullable: false),
                    SamplingSize = table.Column<int>(nullable: false),
                    ResultPassFailId = table.Column<int>(nullable: false),
                    InspectionDetails = table.Column<string>(nullable: true),
                    InspectionToolsId = table.Column<int>(nullable: true),
                    TotalDefectQty = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierVisualInspection", x => x.SupplierVisualInspectionId);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspection_InspectionTools_InspectionToolsId",
                        column: x => x.InspectionToolsId,
                        principalTable: "InspectionTools",
                        principalColumn: "InspectionToolsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspection_PartCountParameterId",
                        column: x => x.PartCountParameterId,
                        principalTable: "PartCountParameter",
                        principalColumn: "PartCountParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspection_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateTable(
                name: "SupplierVisualInspectionDefectType",
                columns: table => new
                {
                    SupplierVisualInspectionDefectTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierVisualInspectionId = table.Column<int>(nullable: false),
                    DefectQty = table.Column<int>(nullable: false),
                    DefectTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierVisualInspectionDefectType", x => x.SupplierVisualInspectionDefectTypeId);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspectionDefectType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspectionDefectType_DefectTypeId",
                        column: x => x.DefectTypeId,
                        principalTable: "DefectType",
                        principalColumn: "DefectTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspectionDefectType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierVisualInspectionDefectType_SupplierVisualInspectionId",
                        column: x => x.SupplierVisualInspectionId,
                        principalTable: "SupplierVisualInspection",
                        principalColumn: "SupplierVisualInspectionId",
                        onDelete: ReferentialAction.Cascade);
                });

        

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_CreatedBy",
                table: "SupplierVisualInspection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_InspectionToolsId",
                table: "SupplierVisualInspection",
                column: "InspectionToolsId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_LastUpdatedBy",
                table: "SupplierVisualInspection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_PartCountParameterId",
                table: "SupplierVisualInspection",
                column: "PartCountParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_SupplierMeasurementSubmissionId",
                table: "SupplierVisualInspection",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspectionDefectType_CreatedBy",
                table: "SupplierVisualInspectionDefectType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspectionDefectType_DefectTypeId",
                table: "SupplierVisualInspectionDefectType",
                column: "DefectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspectionDefectType_LastUpdatedBy",
                table: "SupplierVisualInspectionDefectType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspectionDefectType_SupplierVisualInspection~",
                table: "SupplierVisualInspectionDefectType",
                column: "SupplierVisualInspectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.DropTable(
                name: "SupplierVisualInspectionDefectType");

       

            migrationBuilder.DropTable(
                name: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartCountParameter");
        }
    }
}
