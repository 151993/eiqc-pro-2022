using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class StateTypeSupplier_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CertificateType",
                columns: new[] { "CertificateTypeId", "Name" },
                values: new object[] { 1, "Default" });

            migrationBuilder.InsertData(
                table: "StateType",
                columns: new[] { "StateTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 11, "Rejected By Supplier", "Rejected_By_Supplier" },
                    { 10, "Submitted By Supplier", "Submitted_By_Supplier" }
                });

            migrationBuilder.InsertData(
                table: "CertificateTypeParameter",
                columns: new[] { "CertificateTypeParameterId", "CertificateTypeId", "ParameterName" },
                values: new object[,]
                {
                    { 1, 1, "Media Code" },
                    { 2, 1, "MFG" },
                    { 3, 1, "MPN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CertificateTypeParameter",
                keyColumn: "CertificateTypeParameterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CertificateTypeParameter",
                keyColumn: "CertificateTypeParameterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CertificateTypeParameter",
                keyColumn: "CertificateTypeParameterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CertificateType",
                keyColumn: "CertificateTypeId",
                keyValue: 1);
        }
    }
}
