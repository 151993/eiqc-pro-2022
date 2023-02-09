using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SapPartInspectionPlan_DataTypeRemove_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_DataType_DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_DataTypeId",
                table: "SAPPartInspectionPlan",
                column: "DataTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_DataType_DataTypeId",
                table: "SAPPartInspectionPlan",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
