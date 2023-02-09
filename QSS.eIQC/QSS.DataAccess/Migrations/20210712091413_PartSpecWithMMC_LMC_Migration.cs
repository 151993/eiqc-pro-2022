using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartSpecWithMMC_LMC_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_PartNo",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_PartNo",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_PartNo",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_PartNo",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode1",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode2",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode3",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LineNo",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit1",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit2",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit3",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PositionType",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SampleSize",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit1",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit2",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit3",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "Accuracy",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode1",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode2",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ITCode3",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LineNo",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit1",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit2",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "LowerLimit3",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PositionType",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SampleSize",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UOM",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit1",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit2",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UpperLimit3",
                table: "PartLPositionTolerance");

            migrationBuilder.AlterColumn<int>(
                name: "Spec",
                table: "PartMPositionTolerance",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentTypeId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartDimensionId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SpecLimitAtLMC",
                table: "PartMPositionTolerance",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SpecLimitAtMMC",
                table: "PartMPositionTolerance",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UOMId",
                table: "PartMPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Spec",
                table: "PartLPositionTolerance",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstrumentTypeId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartDimensionId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SpecLimitAtLMC",
                table: "PartLPositionTolerance",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "SpecLimitAtMMC",
                table: "PartLPositionTolerance",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UOMId",
                table: "PartLPositionTolerance",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_DataTypeId",
                table: "PartMPositionTolerance",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_InstrumentTypeId",
                table: "PartMPositionTolerance",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_ParameterManagementId",
                table: "PartMPositionTolerance",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_PartDimensionId",
                table: "PartMPositionTolerance",
                column: "PartDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_SAPPartInspectionPlanId",
                table: "PartMPositionTolerance",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_UOMId",
                table: "PartMPositionTolerance",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_DataTypeId",
                table: "PartLPositionTolerance",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_InstrumentTypeId",
                table: "PartLPositionTolerance",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_ParameterManagementId",
                table: "PartLPositionTolerance",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_PartDimensionId",
                table: "PartLPositionTolerance",
                column: "PartDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_SAPPartInspectionPlanId",
                table: "PartLPositionTolerance",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_UOMId",
                table: "PartLPositionTolerance",
                column: "UOMId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_DataType_DataTypeId",
                table: "PartLPositionTolerance",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_InstrumentTypeId",
                table: "PartLPositionTolerance",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_ParameterManagementId",
                table: "PartLPositionTolerance",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_PartDimensionId",
                table: "PartLPositionTolerance",
                column: "PartDimensionId",
                principalTable: "PartDimension",
                principalColumn: "PartDimensionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_SAPPartInspectionPlanId",
                table: "PartLPositionTolerance",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_UOMId",
                table: "PartLPositionTolerance",
                column: "UOMId",
                principalTable: "UOM",
                principalColumn: "UOMId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_DataType_DataTypeId",
                table: "PartMPositionTolerance",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_InstrumentTypeId",
                table: "PartMPositionTolerance",
                column: "InstrumentTypeId",
                principalTable: "InstrumentType",
                principalColumn: "InstrumentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_ParameterManagementId",
                table: "PartMPositionTolerance",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_PartDimensionId",
                table: "PartMPositionTolerance",
                column: "PartDimensionId",
                principalTable: "PartDimension",
                principalColumn: "PartDimensionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_SAPPartInspectionPlanId",
                table: "PartMPositionTolerance",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_UOMId",
                table: "PartMPositionTolerance",
                column: "UOMId",
                principalTable: "UOM",
                principalColumn: "UOMId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_DataType_DataTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_InstrumentTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_ParameterManagementId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_PartDimensionId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_SAPPartInspectionPlanId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartLPositionTolerance_UOMId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_DataType_DataTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_InstrumentTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_ParameterManagementId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_PartDimensionId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_SAPPartInspectionPlanId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMPositionTolerance_UOMId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_DataTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_InstrumentTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_ParameterManagementId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_PartDimensionId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_SAPPartInspectionPlanId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartMPositionTolerance_UOMId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_DataTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_InstrumentTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_ParameterManagementId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_PartDimensionId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_SAPPartInspectionPlanId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropIndex(
                name: "IX_PartLPositionTolerance_UOMId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "InstrumentTypeId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PartDimensionId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SpecLimitAtLMC",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SpecLimitAtMMC",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "PartMPositionTolerance");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "InstrumentTypeId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "PartDimensionId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SpecLimitAtLMC",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "SpecLimitAtMMC",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "UOMId",
                table: "PartLPositionTolerance");

            migrationBuilder.AlterColumn<double>(
                name: "Spec",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Accuracy",
                table: "PartMPositionTolerance",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode",
                table: "PartMPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ITCode1",
                table: "PartMPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode2",
                table: "PartMPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode3",
                table: "PartMPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineNo",
                table: "PartMPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit1",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit2",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit3",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartMPositionTolerance",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionType",
                table: "PartMPositionTolerance",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SampleSize",
                table: "PartMPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartMPositionTolerance",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "PartMPositionTolerance",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit1",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit2",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit3",
                table: "PartMPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Spec",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Accuracy",
                table: "PartLPositionTolerance",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode",
                table: "PartLPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ITCode1",
                table: "PartLPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode2",
                table: "PartLPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ITCode3",
                table: "PartLPositionTolerance",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineNo",
                table: "PartLPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit1",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit2",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit3",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartLPositionTolerance",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PositionType",
                table: "PartLPositionTolerance",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SampleSize",
                table: "PartLPositionTolerance",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartLPositionTolerance",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "UOM",
                table: "PartLPositionTolerance",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit1",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit2",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "UpperLimit3",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_PartNo",
                table: "PartMPositionTolerance",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_PartNo",
                table: "PartLPositionTolerance",
                column: "PartNo");

            migrationBuilder.AddForeignKey(
                name: "FK_PartLPositionTolerance_PartNo",
                table: "PartLPositionTolerance",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMPositionTolerance_PartNo",
                table: "PartMPositionTolerance",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
