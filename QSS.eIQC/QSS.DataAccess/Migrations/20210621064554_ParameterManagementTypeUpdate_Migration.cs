using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ParameterManagementTypeUpdate_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Visual Inspection", "VisualInspection" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Function-Attribute", "FunctionAttribute" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Dimensional Measurements", "DimensionalMeasurements" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Function-Variable", "FunctionVariable" });

            migrationBuilder.InsertData(
                table: "ParameterManagementType",
                columns: new[] { "ParameterManagementTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 7, "Bow & Twist", "BowAndTwist" },
                    { 8, "Date Code", "DateCode" },
                    { 9, "Spec With MMC", "SpecWithMMC" },
                    { 10, "Spec With LMC", "SpecWithLMC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Count", "Count" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Result-Oriented", "ResultOriented" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Measurement", "Measurement" });

            migrationBuilder.UpdateData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "FUN", "FUN" });
        }
    }
}
