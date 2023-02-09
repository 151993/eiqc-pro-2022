using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierMeasurementManufacturePartNumbersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SMSStatusId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "SupplierMeasurementSubmission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SMSPOStateTypeId",
                table: "SupplierMeasurementSubmission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SMSPOStateType",
                columns: table => new
                {
                    SMSPOStateTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SMSPOStateType", x => x.SMSPOStateTypeId);
                });

            migrationBuilder.InsertData(
                table: "SMSPOStateType",
                columns: new[] { "SMSPOStateTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Pending", "Pending" },
                    { 2, "Complete", "Complete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SMSPOStateTypeId",
                table: "SupplierMeasurementSubmission",
                column: "SMSPOStateTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_SMSPOStateType_SMSPOStateType~",
                table: "SupplierMeasurementSubmission",
                column: "SMSPOStateTypeId",
                principalTable: "SMSPOStateType",
                principalColumn: "SMSPOStateTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_SMSPOStateType_SMSPOStateType~",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropTable(
                name: "SMSPOStateType");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_SMSPOStateTypeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SMSPOStateTypeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.AddColumn<int>(
                name: "SMSStatusId",
                table: "SupplierMeasurementSubmission",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
