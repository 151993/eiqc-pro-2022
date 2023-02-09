using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Add_Chart_Type_Enum_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ChartType",
                keyColumn: "ChartTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "xBar-R", "xBarR" });

            migrationBuilder.UpdateData(
                table: "ChartType",
                keyColumn: "ChartTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "xBar-S", "xBarS" });

            migrationBuilder.InsertData(
                table: "ChartType",
                columns: new[] { "ChartTypeId", "Description", "Name" },
                values: new object[] { 3, "IMR", "IMR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ChartType",
                keyColumn: "ChartTypeId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "ChartType",
                keyColumn: "ChartTypeId",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Individual Control Chart", "IndividualControlChart" });

            migrationBuilder.UpdateData(
                table: "ChartType",
                keyColumn: "ChartTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Range Control Chart", "RangeControlChart" });
        }
    }
}
