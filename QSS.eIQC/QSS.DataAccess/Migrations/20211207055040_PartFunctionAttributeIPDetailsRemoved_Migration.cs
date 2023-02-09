using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartFunctionAttributeIPDetailsRemoved_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InspectionDetails",
                table: "PartResultOrientedParameter");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InspectionDetails",
                table: "PartResultOrientedParameter",
                type: "text",
                nullable: true);
        }
    }
}
