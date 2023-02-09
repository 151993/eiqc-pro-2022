using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DimensionFunMicroSectionParameter_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_PartNo",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_PartNo",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_PartNo",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_PartNo",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_PartNo",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_PartNo",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "ITCode",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "LowerLimit",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "ParameterName",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "SampleSize",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "UpperLimit",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "ITCode",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "LowerLimit",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "ParameterName",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "SampleSize",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "UpperLimit",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "MFGDate",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "Requirement",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "SupplierDC",
                table: "PartFunParameter");

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentTypeId",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LowerTolerance",
                table: "PartMicrosection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UOMId",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "UpperTolerance",
                table: "PartMicrosection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentTypeId",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LowerTolerance",
                table: "PartMeasurementParameter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UOMId",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "UpperTolerance",
                table: "PartMeasurementParameter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Accuracy",
                table: "PartFunParameter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentTypeId",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LowerTolerance",
                table: "PartFunParameter",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "NormalValue",
                table: "PartFunParameter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UOMId",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "UpperTolerance",
                table: "PartFunParameter",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_DataTypeId",
                table: "PartMicrosection",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_InstrumentTypeId",
                table: "PartMicrosection",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_ParameterManagementId",
                table: "PartMicrosection",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_UOMId",
                table: "PartMicrosection",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_DataTypeId",
                table: "PartMeasurementParameter",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_InstrumentTypeId",
                table: "PartMeasurementParameter",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_ParameterManagementId",
                table: "PartMeasurementParameter",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_UOMId",
                table: "PartMeasurementParameter",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_DataTypeId",
                table: "PartFunParameter",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_InstrumentTypeId",
                table: "PartFunParameter",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_ParameterManagementId",
                table: "PartFunParameter",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_UOMId",
                table: "PartFunParameter",
                column: "UOMId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_DataTypeId",
                table: "PartFunParameter",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_InstrumentTypeId",
                table: "PartFunParameter",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_ParameterManagementId",
                table: "PartFunParameter",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_UOMId",
                table: "PartFunParameter",
                column: "UOMId",
                principalTable: "UOM",
                principalColumn: "UOMId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_DataTypeId",
                table: "PartMeasurementParameter",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_InstrumentTypeId",
                table: "PartMeasurementParameter",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_ParameterManagementId",
                table: "PartMeasurementParameter",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_UOMId",
                table: "PartMeasurementParameter",
                column: "UOMId",
                principalTable: "UOM",
                principalColumn: "UOMId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_DataTypeId",
                table: "PartMicrosection",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_InstrumentTypeId",
                table: "PartMicrosection",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_ParameterManagementId",
                table: "PartMicrosection",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_UOMId",
                table: "PartMicrosection",
                column: "UOMId",
                principalTable: "UOM",
                principalColumn: "UOMId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_DataTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_InstrumentTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_ParameterManagementId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_UOMId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_DataTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_InstrumentTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_ParameterManagementId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_UOMId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_DataTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_InstrumentTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_ParameterManagementId",
                table: "PartMicrosection");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_UOMId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_DataTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_InstrumentTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_ParameterManagementId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_UOMId",
                table: "PartMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_DataTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_InstrumentTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_ParameterManagementId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_UOMId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_DataTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_InstrumentTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_ParameterManagementId",
                table: "PartFunParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_UOMId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "InstrumentTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "LowerTolerance",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "UpperTolerance",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "InstrumentTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "LowerTolerance",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "UpperTolerance",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "InstrumentTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "LowerTolerance",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "NormalValue",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "UpperTolerance",
                table: "PartFunParameter");

            migrationBuilder.AddColumn<string>(
                name: "ITCode",
                table: "PartMicrosection",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit",
                table: "PartMicrosection",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ParameterName",
                table: "PartMicrosection",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartMicrosection",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SampleSize",
                table: "PartMicrosection",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartMicrosection",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "PartMicrosection",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit",
                table: "PartMicrosection",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ITCode",
                table: "PartMeasurementParameter",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit",
                table: "PartMeasurementParameter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ParameterName",
                table: "PartMeasurementParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartMeasurementParameter",
                type: "character varying(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SampleSize",
                table: "PartMeasurementParameter",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartMeasurementParameter",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "PartMeasurementParameter",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit",
                table: "PartMeasurementParameter",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "MFGDate",
                table: "PartFunParameter",
                type: "character varying(53)",
                maxLength: 53,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartFunParameter",
                type: "character varying(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirement",
                table: "PartFunParameter",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "PartFunParameter",
                type: "character varying(53)",
                maxLength: 53,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartFunParameter",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "SupplierDC",
                table: "PartFunParameter",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_PartNo",
                table: "PartMicrosection",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_PartNo",
                table: "PartMeasurementParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_PartNo",
                table: "PartFunParameter",
                column: "PartNo");

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_PartNo",
                table: "PartFunParameter",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_PartNo",
                table: "PartMeasurementParameter",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_PartNo",
                table: "PartMicrosection",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
