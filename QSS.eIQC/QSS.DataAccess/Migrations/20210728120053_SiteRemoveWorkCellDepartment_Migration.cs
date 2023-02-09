using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SiteRemoveWorkCellDepartment_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteDepartment_DepartmentId",
                table: "SiteDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDepartment_SiteId",
                table: "SiteDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteWorkCell_SiteId",
                table: "SiteWorkCell");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteWorkCell_WorkCellId",
                table: "SiteWorkCell");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDepartment_Department_DepartmentId",
                table: "SiteDepartment",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDepartment_Site_SiteId",
                table: "SiteDepartment",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWorkCell_Site_SiteId",
                table: "SiteWorkCell",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWorkCell_WorkCell_WorkCellId",
                table: "SiteWorkCell",
                column: "WorkCellId",
                principalTable: "WorkCell",
                principalColumn: "WorkCellId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SiteDepartment_Department_DepartmentId",
                table: "SiteDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDepartment_Site_SiteId",
                table: "SiteDepartment");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteWorkCell_Site_SiteId",
                table: "SiteWorkCell");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteWorkCell_WorkCell_WorkCellId",
                table: "SiteWorkCell");

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDepartment_DepartmentId",
                table: "SiteDepartment",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDepartment_SiteId",
                table: "SiteDepartment",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWorkCell_SiteId",
                table: "SiteWorkCell",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteWorkCell_WorkCellId",
                table: "SiteWorkCell",
                column: "WorkCellId",
                principalTable: "WorkCell",
                principalColumn: "WorkCellId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
