using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class UpdatedStateContent_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 3,
                column: "Description",
                value: "Pending Approval By Jabil");

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Approved By SQE", "Approved_By_SQE" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Rejected By SQE", "Rejected_By_SQE" });

            migrationBuilder.InsertData(
                table: "StateType",
                columns: new[] { "StateTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 6, "Deactivated By SQE", "Deactivated_By_SQE" },
                    { 7, "Redefined By SQE", "Redefined_By_SQE" },
                    { 8, "Approved By DCC", "Approved_By_DCC" },
                    { 9, "Rejected By DCC", "Rejected_By_DCC" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 3,
                column: "Description",
                value: "Pending approval By Jabil");

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Approved By Jabil ", "Approved_By_Jabil" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Rejected By Jabil", "Rejected_By_Jabil" });
        }
    }
}
