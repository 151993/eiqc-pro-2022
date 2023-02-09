using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class bulk_Form_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RolePermissionId",
                table: "RolePermission",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'47', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'40', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "Buyer",
                columns: table => new
                {
                    BuyerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    BuyerCode = table.Column<string>(maxLength: 100, nullable: false),
                    BuyerMail = table.Column<string>(maxLength: 50, nullable: false),
                    IsValid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyer", x => x.BuyerId);
                    table.ForeignKey(
                        name: "FK_Buyer_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Buyer_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompletedGRS",
                columns: table => new
                {
                    CompletedGRSId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 255, nullable: true),
                    UDCode = table.Column<string>(maxLength: 255, nullable: true),
                    GRSNo = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompletedGRS", x => x.CompletedGRSId);
                    table.ForeignKey(
                        name: "FK_CompletedGRS_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompletedGRS_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CTParameter",
                columns: table => new
                {
                    CTParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTParameter", x => x.CTParameterId);
                    table.ForeignKey(
                        name: "FK_CTParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CAFPath = table.Column<string>(maxLength: 250, nullable: true),
                    DCCSavePath = table.Column<string>(maxLength: 250, nullable: true),
                    CAFTempPath = table.Column<string>(maxLength: 250, nullable: true),
                    BackupSavePath = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customer_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customer_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefectType",
                columns: table => new
                {
                    DefectTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    DataType = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    IsValid = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectType", x => x.DefectTypeId);
                    table.ForeignKey(
                        name: "FK_DefectType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefectType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DispositionType",
                columns: table => new
                {
                    DispositionTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispositionType", x => x.DispositionTypeId);
                    table.ForeignKey(
                        name: "FK_DispositionType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispositionType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormType",
                columns: table => new
                {
                    FormTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormType", x => x.FormTypeId);
                    table.ForeignKey(
                        name: "FK_FormType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceiveUser",
                columns: table => new
                {
                    GoodsReceiveUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    WareHouse = table.Column<string>(maxLength: 250, nullable: true),
                    SAPUser = table.Column<string>(maxLength: 250, nullable: true),
                    UserName = table.Column<string>(maxLength: 250, nullable: true),
                    SupervisorMail = table.Column<string>(maxLength: 250, nullable: true),
                    LeaderMail = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceiveUser", x => x.GoodsReceiveUserId);
                    table.ForeignKey(
                        name: "FK_GoodsReceiveUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceiveUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    WareHouse = table.Column<string>(maxLength: 250, nullable: true),
                    UserName = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.GroupId);
                    table.ForeignKey(
                        name: "FK_Group_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Group_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GRSSAPResult",
                columns: table => new
                {
                    GRSSAPResultId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    GRSNO = table.Column<string>(maxLength: 250, nullable: true),
                    ISOK = table.Column<string>(maxLength: 250, nullable: true),
                    Error = table.Column<string>(maxLength: 250, nullable: true),
                    NTID = table.Column<string>(maxLength: 250, nullable: true),
                    PayLoad = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRSSAPResult", x => x.GRSSAPResultId);
                    table.ForeignKey(
                        name: "FK_GRSSAPResult_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRSSAPResult_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InspectionToolsType",
                columns: table => new
                {
                    InspectionToolsTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    NTID = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionToolsType", x => x.InspectionToolsTypeId);
                    table.ForeignKey(
                        name: "FK_InspectionToolsType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionToolsType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstrumentType",
                columns: table => new
                {
                    InstrumentTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    UserName = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstrumentType", x => x.InstrumentTypeId);
                    table.ForeignKey(
                        name: "FK_InstrumentType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstrumentType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LotInspectionQty",
                columns: table => new
                {
                    LotInspectionQtyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    LotNo = table.Column<string>(maxLength: 250, nullable: true),
                    Material = table.Column<string>(maxLength: 250, nullable: true),
                    MstrChar = table.Column<string>(maxLength: 250, nullable: true),
                    InspStg = table.Column<string>(maxLength: 250, nullable: true),
                    INspectQty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LotInspectionQty", x => x.LotInspectionQtyId);
                    table.ForeignKey(
                        name: "FK_LotInspectionQty_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LotInspectionQty_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterType",
                columns: table => new
                {
                    ParameterTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Code = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    ComparationMethodDescription = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterType", x => x.ParameterTypeId);
                    table.ForeignKey(
                        name: "FK_ParameterType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartCAF",
                columns: table => new
                {
                    PartCAFId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 50, nullable: false),
                    Hyperlink = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartCAF", x => x.PartCAFId);
                    table.ForeignKey(
                        name: "FK_PartCAF_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartCAF_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PCCode",
                columns: table => new
                {
                    PCCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PcCode = table.Column<string>(maxLength: 50, nullable: false),
                    Hyperlink = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCCode", x => x.PCCodeId);
                    table.ForeignKey(
                        name: "FK_PCCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PCCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveGoodsInfo",
                columns: table => new
                {
                    ReceiveGoodsInfoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Plant = table.Column<string>(maxLength: 250, nullable: true),
                    MatlGroup = table.Column<string>(maxLength: 250, nullable: true),
                    Material = table.Column<string>(maxLength: 250, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ReceivedDateTime = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "((CURRENT_TIMESTAMP))"),
                    MocDoc = table.Column<string>(maxLength: 250, nullable: true),
                    StorLoc = table.Column<string>(maxLength: 250, nullable: true),
                    MvmtType = table.Column<string>(nullable: true),
                    Batch = table.Column<string>(maxLength: 250, nullable: true),
                    Vendor = table.Column<string>(maxLength: 250, nullable: true),
                    User = table.Column<string>(maxLength: 250, nullable: true),
                    SpecStock = table.Column<string>(maxLength: 250, nullable: true),
                    Reference = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveGoodsInfo", x => x.ReceiveGoodsInfoId);
                    table.ForeignKey(
                        name: "FK_ReceiveGoodsInfo_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiveGoodsInfo_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveGoodsInfoManual",
                columns: table => new
                {
                    ReceiveGoodsInfoManualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Plant = table.Column<string>(maxLength: 250, nullable: true),
                    MatlGroup = table.Column<string>(maxLength: 250, nullable: true),
                    Material = table.Column<string>(maxLength: 250, nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    ReceivedDateTime = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "((CURRENT_TIMESTAMP))"),
                    MocDoc = table.Column<string>(maxLength: 250, nullable: true),
                    StorLoc = table.Column<string>(maxLength: 250, nullable: true),
                    MvmtType = table.Column<string>(nullable: true),
                    Batch = table.Column<string>(maxLength: 250, nullable: true),
                    Vendor = table.Column<string>(maxLength: 250, nullable: true),
                    User = table.Column<string>(maxLength: 250, nullable: true),
                    SpecStock = table.Column<string>(maxLength: 250, nullable: true),
                    Reference = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveGoodsInfoManual", x => x.ReceiveGoodsInfoManualId);
                    table.ForeignKey(
                        name: "FK_ReceiveGoodsInfoManual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceiveGoodsInfoManual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rosetta",
                columns: table => new
                {
                    RosettaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    EN_US = table.Column<string>(maxLength: 250, nullable: true),
                    ZH_CN = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rosetta", x => x.RosettaId);
                    table.ForeignKey(
                        name: "FK_Rosetta_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rosetta_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierForm",
                columns: table => new
                {
                    SupplierFormId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PONo = table.Column<string>(maxLength: 255, nullable: false),
                    PartNo = table.Column<string>(maxLength: 50, nullable: true),
                    FileName = table.Column<string>(maxLength: 4000, nullable: false),
                    DateCode = table.Column<string>(maxLength: 200, nullable: true),
                    DateCodeActual = table.Column<bool>(nullable: false),
                    ApproveTime = table.Column<DateTimeOffset>(nullable: true),
                    ApproveUser = table.Column<string>(maxLength: 255, nullable: false),
                    TotalQty = table.Column<int>(nullable: false),
                    SampleQty = table.Column<int>(nullable: false),
                    Inspector = table.Column<string>(maxLength: 255, nullable: false),
                    Verify = table.Column<string>(maxLength: 255, nullable: false),
                    ImportStatus = table.Column<int>(nullable: false),
                    ImportError = table.Column<string>(maxLength: 4000, nullable: false),
                    MO = table.Column<string>(maxLength: 255, nullable: false),
                    MovedPath = table.Column<string>(maxLength: 4000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierForm", x => x.SupplierFormId);
                    table.ForeignKey(
                        name: "FK_SupplierForm_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierForm_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UOM",
                columns: table => new
                {
                    UOMId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOM", x => x.UOMId);
                    table.ForeignKey(
                        name: "FK_UOM_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UOM_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Part",
                columns: table => new
                {
                    PartId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 25, nullable: false),
                    CAF = table.Column<string>(maxLength: 250, nullable: true),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    LastTime = table.Column<DateTimeOffset>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    IPVersion = table.Column<string>(maxLength: 100, nullable: true),
                    Supervisor = table.Column<string>(maxLength: 20, nullable: true),
                    SupervisorTime = table.Column<DateTimeOffset>(nullable: true),
                    DCCUser = table.Column<string>(maxLength: 20, nullable: true),
                    DCCTime = table.Column<DateTimeOffset>(nullable: true),
                    RefDoc = table.Column<string>(maxLength: 50, nullable: true),
                    Remark = table.Column<string>(maxLength: 350, nullable: true),
                    BackupSoftcopy = table.Column<string>(maxLength: 250, nullable: true),
                    LastIPVersion = table.Column<string>(maxLength: 100, nullable: true),
                    LastCAFName = table.Column<string>(maxLength: 100, nullable: true),
                    Division = table.Column<string>(maxLength: 50, nullable: true),
                    Commodity = table.Column<string>(maxLength: 50, nullable: true),
                    GENWI = table.Column<string>(maxLength: 255, nullable: true),
                    MPositionType = table.Column<int>(nullable: true),
                    LPositionType = table.Column<int>(nullable: true),
                    SafePartFlag = table.Column<int>(nullable: true),
                    CAF_Backup = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Part", x => x.PartId);
                    table.UniqueConstraint("AK_Part_PartNo", x => x.PartNo);
                    table.ForeignKey(
                        name: "FK_Part_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Part_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Part_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCustomer",
                columns: table => new
                {
                    UserCustomerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCustomer", x => x.UserCustomerId);
                    table.ForeignKey(
                        name: "FK_UserCustomer_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCustomer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCustomer_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCustomer_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InspectionTools",
                columns: table => new
                {
                    InspectionToolsId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    InspectionToolsTypeId = table.Column<int>(nullable: false),
                    IToolsName = table.Column<string>(maxLength: 20, nullable: false),
                    Valid = table.Column<DateTime>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    NTID = table.Column<string>(maxLength: 10, nullable: false),
                    LastTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionTools", x => x.InspectionToolsId);
                    table.ForeignKey(
                        name: "FK_InspectionTools_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionTools_InspectionToolsTypeId",
                        column: x => x.InspectionToolsTypeId,
                        principalTable: "InspectionToolsType",
                        principalColumn: "InspectionToolsTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InspectionTools_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instrument",
                columns: table => new
                {
                    InstrumentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    InstrumentTypeId = table.Column<int>(nullable: false),
                    Desc = table.Column<string>(maxLength: 50, nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    LastTime = table.Column<DateTimeOffset>(nullable: false),
                    ExpireDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instrument", x => x.InstrumentId);
                    table.ForeignKey(
                        name: "FK_Instrument_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instrument_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Instrument_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterCategory",
                columns: table => new
                {
                    ParameterCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Sequence = table.Column<int>(nullable: true),
                    MultiSampling = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    PCCodeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterCategory", x => x.ParameterCategoryId);
                    table.ForeignKey(
                        name: "FK_ParameterCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterCategory_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterCategory_PCCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PCCodeInspectionToolsType",
                columns: table => new
                {
                    PCCodeInspectionToolsTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PCCodeId = table.Column<int>(nullable: false),
                    InspectionToolsTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCCodeInspectionToolsType", x => x.PCCodeInspectionToolsTypeId);
                    table.ForeignKey(
                        name: "FK_PCCodeInspectionToolsType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PCCodeInspectionToolsType_InspectionToolsType_InspectionToo~",
                        column: x => x.InspectionToolsTypeId,
                        principalTable: "InspectionToolsType",
                        principalColumn: "InspectionToolsTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PCCodeInspectionToolsType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PCCodeInspectionToolsType_PCCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierAttachment",
                columns: table => new
                {
                    SupplierAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ATType = table.Column<string>(nullable: true),
                    Path = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierAttachment", x => x.SupplierAttachmentId);
                    table.ForeignKey(
                        name: "FK_SupplierAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierAttachment_SupplierForm_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormBowTwistActual",
                columns: table => new
                {
                    SupplierFormBowTwistActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    WarpType = table.Column<int>(nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormBowTwistActual", x => x.SupplierFormBowTwistActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormBowTwistParameter",
                columns: table => new
                {
                    SupplierFormBowTwistParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    WarpType = table.Column<int>(nullable: false),
                    Spec = table.Column<string>(maxLength: 255, nullable: true),
                    Length = table.Column<string>(maxLength: 53, nullable: true),
                    Width = table.Column<string>(maxLength: 53, nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: true),
                    UpperLimit = table.Column<string>(maxLength: 50, nullable: true),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormBowTwistParameter", x => x.SupplierFormBowTwistParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormBowTwistParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormCountParameter",
                columns: table => new
                {
                    SupplierFormCountParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    FailedQTYExpected = table.Column<int>(nullable: true),
                    FailedQTYActual = table.Column<int>(nullable: true),
                    IToolsID = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 200, nullable: true),
                    InspectionDetails = table.Column<string>(maxLength: 255, nullable: true),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormCountParameter", x => x.SupplierFormCountParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormCountParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormCountParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormCountParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormFunPara",
                columns: table => new
                {
                    SupplierFormFunParaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentID = table.Column<string>(maxLength: 20, nullable: true),
                    ITCode = table.Column<string>(maxLength: 20, nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: true),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: true),
                    LowerLimit = table.Column<double>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormFunPara", x => x.SupplierFormFunParaId);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunPara_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunPara_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunPara_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormFunParaActual",
                columns: table => new
                {
                    SupplierFormFunParaActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormFunParaActual", x => x.SupplierFormFunParaActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunParaActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunParaActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormFunParaActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormLPosition",
                columns: table => new
                {
                    SupplierFormLPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormLPosition", x => x.SupplierFormLPositionId);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPosition_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormLPositionActual",
                columns: table => new
                {
                    SupplierFormLPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true),
                    PositionCalcul = table.Column<double>(nullable: true),
                    PositionActual = table.Column<double>(nullable: true),
                    Result = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID = table.Column<string>(maxLength: 200, nullable: true),
                    Base1Actual = table.Column<double>(nullable: true),
                    Base2Actual = table.Column<double>(nullable: true),
                    Base3Actual = table.Column<double>(nullable: true),
                    InstrumentID1 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID2 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID3 = table.Column<string>(maxLength: 200, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormLPositionActual", x => x.SupplierFormLPositionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormLPositionActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMeasurementParameter",
                columns: table => new
                {
                    SupplierFormMeasurementParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentID = table.Column<string>(maxLength: 20, nullable: true),
                    InstrumentTypeID = table.Column<string>(nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMeasurementParameter", x => x.SupplierFormMeasurementParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMeasurementParameterActual",
                columns: table => new
                {
                    SupplierFormMeasurementParameterActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: true),
                    ValueActual = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMeasurementParameterActual", x => x.SupplierFormMeasurementParameterActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameterActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameterActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMeasurementParameterActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMicroSection",
                columns: table => new
                {
                    SupplierFormMicroSectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentID = table.Column<string>(maxLength: 20, nullable: true),
                    ITCode = table.Column<string>(maxLength: 20, nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: true),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: true),
                    LowerLimit = table.Column<double>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMicroSection", x => x.SupplierFormMicroSectionId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSection_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMicroSectionActual",
                columns: table => new
                {
                    SupplierFormMicroSectionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMicroSectionActual", x => x.SupplierFormMicroSectionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSectionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSectionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMicroSectionActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMPosition",
                columns: table => new
                {
                    SupplierFormMPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMPosition", x => x.SupplierFormMPositionId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPosition_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormMPositionActual",
                columns: table => new
                {
                    SupplierFormMPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true),
                    PositionCalcul = table.Column<double>(nullable: true),
                    PositionActual = table.Column<double>(nullable: true),
                    Result = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID = table.Column<string>(maxLength: 200, nullable: true),
                    Base1Actual = table.Column<double>(nullable: true),
                    Base2Actual = table.Column<double>(nullable: true),
                    Base3Actual = table.Column<double>(nullable: true),
                    InstrumentID1 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID2 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID3 = table.Column<string>(maxLength: 200, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormMPositionActual", x => x.SupplierFormMPositionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormMPositionActual_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormPackaging",
                columns: table => new
                {
                    SupplierFormPackagingId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ResultDesc = table.Column<string>(maxLength: 50, nullable: false),
                    Result = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormPackaging", x => x.SupplierFormPackagingId);
                    table.ForeignKey(
                        name: "FK_SupplierFormPackaging_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormPackaging_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormPackaging_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormPartDateCode",
                columns: table => new
                {
                    SupplierFormPartDateCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    Requirement = table.Column<string>(maxLength: 255, nullable: false),
                    SupplierDC = table.Column<string>(maxLength: 255, nullable: false),
                    MFGDate = table.Column<string>(maxLength: 100, nullable: false),
                    Result = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormPartDateCode", x => x.SupplierFormPartDateCodeId);
                    table.ForeignKey(
                        name: "FK_SupplierFormPartDateCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormPartDateCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormPartDateCode_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormResultOrientedParameter",
                columns: table => new
                {
                    SupplierFormResultOrientedParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 250, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    ResultActual = table.Column<bool>(nullable: false),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: false),
                    InspectionDetails = table.Column<string>(maxLength: 255, nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormResultOrientedParameter", x => x.SupplierFormResultOrientedParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormResultOrientedParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormResultOrientedParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormResultOrientedParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormSAPParameter",
                columns: table => new
                {
                    SupplierFormSAPParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 250, nullable: false),
                    SAPParameterExpected = table.Column<string>(maxLength: 50, nullable: false),
                    SAPParameterActual = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormSAPParameter", x => x.SupplierFormSAPParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormSAPParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormSAPParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormSAPParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormSpecialParameter",
                columns: table => new
                {
                    SupplierFormSpecialParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 250, nullable: false),
                    ResultDesc = table.Column<string>(maxLength: 250, nullable: false),
                    Result = table.Column<bool>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormSpecialParameter", x => x.SupplierFormSpecialParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierFormSpecialParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormSpecialParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormSpecialParameter_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormTestReport",
                columns: table => new
                {
                    SupplierFormTestReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: false),
                    ResultActual = table.Column<bool>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormTestReport", x => x.SupplierFormTestReportId);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormTestReport_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFormVIS",
                columns: table => new
                {
                    SupplierFormVISId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    AcceptanceQTY = table.Column<int>(nullable: false),
                    TotalFailedQTY = table.Column<int>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFormVIS", x => x.SupplierFormVISId);
                    table.ForeignKey(
                        name: "FK_SupplierFormVIS_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormVIS_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFormVIS_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GRS",
                columns: table => new
                {
                    GRSId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    GRSNo = table.Column<string>(maxLength: 20, nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    MedialCode = table.Column<string>(maxLength: 50, nullable: true),
                    MPN = table.Column<string>(maxLength: 50, nullable: true),
                    MaterialName = table.Column<string>(maxLength: 100, nullable: true),
                    MFG = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    LotNo = table.Column<string>(maxLength: 50, nullable: true),
                    InspectQty = table.Column<int>(nullable: true),
                    RejectionQty = table.Column<int>(nullable: true),
                    InspectorName = table.Column<string>(maxLength: 8000, nullable: true),
                    InspectionResult = table.Column<string>(maxLength: 8000, nullable: true),
                    GRSNoType = table.Column<string>(nullable: true),
                    PO = table.Column<string>(maxLength: 255, nullable: true),
                    VendorCode = table.Column<string>(maxLength: 255, nullable: true),
                    MatlGroup = table.Column<string>(maxLength: 255, nullable: true),
                    VendorName1 = table.Column<string>(maxLength: 255, nullable: true),
                    SkipIQC = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRS", x => x.GRSId);
                    table.ForeignKey(
                        name: "FK_GRS_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRS_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRS_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartBowTwistParameter",
                columns: table => new
                {
                    PartBowTwistParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 25, nullable: true),
                    WarpType = table.Column<int>(nullable: true),
                    Spec = table.Column<string>(maxLength: 255, nullable: true),
                    Length = table.Column<string>(maxLength: 53, nullable: true),
                    Width = table.Column<string>(maxLength: 53, nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: true),
                    UpperLimit = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartBowTwistParameter", x => x.PartBowTwistParameterId);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartCountParameter",
                columns: table => new
                {
                    PartCountParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    FailedQTYExpected = table.Column<int>(nullable: true),
                    InspectionToolsTypeId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartCountParameter", x => x.PartCountParameterId);
                    table.ForeignKey(
                        name: "FK_PartCountParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartCountParameter_InspectionToolsType_InspectionToolsTypeId",
                        column: x => x.InspectionToolsTypeId,
                        principalTable: "InspectionToolsType",
                        principalColumn: "InspectionToolsTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PartCountParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartCountParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartDateCode",
                columns: table => new
                {
                    PartDateCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 25, nullable: true),
                    Requirement = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierDC = table.Column<string>(maxLength: 255, nullable: true),
                    MFGDate = table.Column<string>(maxLength: 53, nullable: true),
                    Result = table.Column<string>(maxLength: 53, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartDateCode", x => x.PartDateCodeId);
                    table.ForeignKey(
                        name: "FK_PartDateCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartDateCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartDateCode_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartFunParameter",
                columns: table => new
                {
                    PartFunParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 25, nullable: true),
                    Requirement = table.Column<string>(maxLength: 100, nullable: true),
                    SupplierDC = table.Column<string>(maxLength: 255, nullable: true),
                    MFGDate = table.Column<string>(maxLength: 53, nullable: true),
                    Result = table.Column<string>(maxLength: 53, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartFunParameter", x => x.PartFunParameterId);
                    table.ForeignKey(
                        name: "FK_PartFunParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartFunParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartFunParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartLPositionTolerance",
                columns: table => new
                {
                    PartLPositionToleranceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartLPositionTolerance", x => x.PartLPositionToleranceId);
                    table.ForeignKey(
                        name: "FK_PartLPositionTolerance_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartLPositionTolerance_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartLPositionTolerance_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartMeasurementParameter",
                columns: table => new
                {
                    PartMeasurementParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(maxLength: 25, nullable: true),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartMeasurementParameter", x => x.PartMeasurementParameterId);
                    table.ForeignKey(
                        name: "FK_PartMeasurementParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMeasurementParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMeasurementParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartMicrosection",
                columns: table => new
                {
                    PartMicrosectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartMicrosection", x => x.PartMicrosectionId);
                    table.ForeignKey(
                        name: "FK_PartMicrosection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMicrosection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMicrosection_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartMPositionTolerance",
                columns: table => new
                {
                    PartMPositionToleranceId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartMPositionTolerance", x => x.PartMPositionToleranceId);
                    table.ForeignKey(
                        name: "FK_PartMPositionTolerance_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMPositionTolerance_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartMPositionTolerance_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartResultOrientedParameter",
                columns: table => new
                {
                    PartResultOrientedParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartResultOrientedParameter", x => x.PartResultOrientedParameterId);
                    table.ForeignKey(
                        name: "FK_PartResultOrientedParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartResultOrientedParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartResultOrientedParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartTestReportParameter",
                columns: table => new
                {
                    PartTestReportParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartNo = table.Column<string>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: true),
                    ResultActual = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTestReportParameter", x => x.PartTestReportParameterId);
                    table.ForeignKey(
                        name: "FK_PartTestReportParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTestReportParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartTestReportParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SAPPartInspectionPlan",
                columns: table => new
                {
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    PartId = table.Column<int>(nullable: true),
                    PartNo = table.Column<string>(nullable: true),
                    PCCodeId = table.Column<int>(nullable: false),
                    SamplingProc = table.Column<string>(maxLength: 20, nullable: true),
                    QMControlKey = table.Column<string>(maxLength: 20, nullable: true),
                    CertificateType = table.Column<string>(nullable: true),
                    MstrChar = table.Column<string>(maxLength: 20, nullable: true),
                    InspectionCharac = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPPartInspectionPlan", x => x.SAPPartInspectionPlanId);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_PCCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_Part_PartId",
                        column: x => x.PartId,
                        principalTable: "Part",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Form",
                columns: table => new
                {
                    FormId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormTypeId = table.Column<int>(nullable: false),
                    GRSId = table.Column<int>(nullable: false),
                    DPID = table.Column<string>(maxLength: 20, nullable: true),
                    SampleQTY = table.Column<int>(nullable: false),
                    DateCode = table.Column<string>(maxLength: 200, nullable: true),
                    DateCodeActual = table.Column<bool>(nullable: true),
                    FinalResult = table.Column<bool>(nullable: true),
                    Remark = table.Column<string>(maxLength: 1000, nullable: true),
                    UserName = table.Column<string>(maxLength: 20, nullable: true),
                    QN = table.Column<string>(maxLength: 20, nullable: true),
                    IPVersion = table.Column<string>(maxLength: 100, nullable: true),
                    RefDoc = table.Column<string>(maxLength: 50, nullable: true),
                    QNSoftcopy = table.Column<string>(maxLength: 100, nullable: true),
                    GRSNoType = table.Column<string>(nullable: true),
                    BatchDC = table.Column<string>(maxLength: 255, nullable: true),
                    StorageLoc = table.Column<string>(maxLength: 255, nullable: true),
                    RequireStatus = table.Column<int>(nullable: true),
                    PackQty = table.Column<int>(nullable: true),
                    QtyPerBox = table.Column<double>(nullable: true),
                    OddQtyPerBox = table.Column<string>(maxLength: 100, nullable: true),
                    ReceivingInfo = table.Column<string>(maxLength: 4000, nullable: true),
                    DANo = table.Column<string>(maxLength: 200, nullable: true),
                    PackSampleQty = table.Column<int>(nullable: true),
                    BuyerID = table.Column<int>(nullable: true),
                    DivisionId = table.Column<int>(nullable: true),
                    SAPDefectTypeID = table.Column<int>(nullable: true),
                    VISDefectTypeID = table.Column<int>(nullable: true),
                    FUNDefectTypeID = table.Column<int>(nullable: true),
                    FunMeasureTypeID = table.Column<int>(nullable: true),
                    DIMDefectTypeID = table.Column<int>(nullable: true),
                    MPositionDefectTypeID = table.Column<int>(nullable: true),
                    LPositionDefectTypeID = table.Column<int>(nullable: true),
                    DateCodeDefectTypeID = table.Column<int>(nullable: true),
                    BowTwistDefectTypeID = table.Column<int>(nullable: true),
                    FunParaDefectTypeID = table.Column<int>(nullable: true),
                    MicroDefectTypeID = table.Column<int>(nullable: true),
                    TestReportDefectTypeID = table.Column<int>(nullable: true),
                    SpecDefectType = table.Column<string>(nullable: true),
                    LastFormID = table.Column<int>(nullable: true),
                    LockFlag = table.Column<int>(nullable: true),
                    LockUser = table.Column<string>(maxLength: 255, nullable: true),
                    DCRequirement = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form", x => x.FormId);
                    table.ForeignKey(
                        name: "FK_Form_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Form_FormType_FormTypeId",
                        column: x => x.FormTypeId,
                        principalTable: "FormType",
                        principalColumn: "FormTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Form_GRS_GRSId",
                        column: x => x.GRSId,
                        principalTable: "GRS",
                        principalColumn: "GRSId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Form_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GRSSupplierForm",
                columns: table => new
                {
                    GRSSupplierFormId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFormId = table.Column<int>(nullable: false),
                    GRSId = table.Column<int>(nullable: true),
                    GRSNo = table.Column<string>(maxLength: 255, nullable: true),
                    SubmitUser = table.Column<string>(maxLength: 255, nullable: true),
                    SubmitTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GRSSupplierForm", x => x.GRSSupplierFormId);
                    table.ForeignKey(
                        name: "FK_GRSSupplierForm_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRSSupplierForm_GRS_GRSId",
                        column: x => x.GRSId,
                        principalTable: "GRS",
                        principalColumn: "GRSId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GRSSupplierForm_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GRSSupplierForm_SupplierFormId",
                        column: x => x.SupplierFormId,
                        principalTable: "SupplierForm",
                        principalColumn: "SupplierFormId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormBowTwistActual",
                columns: table => new
                {
                    FormBowTwistActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 250, nullable: false),
                    SAPParameterExpected = table.Column<string>(maxLength: 50, nullable: false),
                    SAPParameterActual = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormBowTwistActual", x => x.FormBowTwistActualId);
                    table.ForeignKey(
                        name: "FK_FormBowTwistActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormBowTwistActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormBowTwistActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormBowTwistParameter",
                columns: table => new
                {
                    FormBowTwistParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    WarpType = table.Column<int>(nullable: true),
                    Spec = table.Column<string>(maxLength: 255, nullable: true),
                    Length = table.Column<string>(maxLength: 53, nullable: true),
                    Width = table.Column<string>(maxLength: 53, nullable: true),
                    Unit = table.Column<string>(maxLength: 10, nullable: true),
                    UpperLimit = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormBowTwistParameter", x => x.FormBowTwistParameterId);
                    table.ForeignKey(
                        name: "FK_FormBowTwistParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormBowTwistParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormBowTwistParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormCountParameter",
                columns: table => new
                {
                    FormCountParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    FailedQTYExpected = table.Column<int>(nullable: true),
                    FailedQTYActual = table.Column<int>(nullable: true),
                    InspectionToolsId = table.Column<int>(nullable: true),
                    Remark = table.Column<string>(maxLength: 4000, nullable: true),
                    InspectionDetails = table.Column<string>(maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormCountParameter", x => x.FormCountParameterId);
                    table.ForeignKey(
                        name: "FK_FormCountParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormCountParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormCountParameter_InspectionTools_InspectionToolsId",
                        column: x => x.InspectionToolsId,
                        principalTable: "InspectionTools",
                        principalColumn: "InspectionToolsId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormCountParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormFunPara",
                columns: table => new
                {
                    FormFunParaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentId = table.Column<int>(nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: true),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: true),
                    LowerLimit = table.Column<double>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFunPara", x => x.FormFunParaId);
                    table.ForeignKey(
                        name: "FK_FormFunPara_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormFunPara_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormFunPara_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormFunParaActual",
                columns: table => new
                {
                    FormFunParaActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFunParaActual", x => x.FormFunParaActualId);
                    table.ForeignKey(
                        name: "FK_FormFunParaActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormFunParaActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormFunParaActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormLPosition",
                columns: table => new
                {
                    FormLPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormLPosition", x => x.FormLPositionId);
                    table.ForeignKey(
                        name: "FK_FormLPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormLPosition_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormLPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormLPositionActual",
                columns: table => new
                {
                    FormLPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true),
                    PositionCalcul = table.Column<double>(nullable: true),
                    PositionActual = table.Column<double>(nullable: true),
                    Result = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID = table.Column<string>(maxLength: 200, nullable: true),
                    Base1Actual = table.Column<double>(nullable: true),
                    Base2Actual = table.Column<double>(nullable: true),
                    Base3Actual = table.Column<double>(nullable: true),
                    InstrumentID1 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID2 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID3 = table.Column<string>(maxLength: 200, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormLPositionActual", x => x.FormLPositionActualId);
                    table.ForeignKey(
                        name: "FK_FormLPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormLPositionActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormLPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMeasurementParameter",
                columns: table => new
                {
                    FormMeasurementParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentId = table.Column<int>(nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMeasurementParameter", x => x.FormMeasurementParameterId);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameter_Instrument_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMeasurementParameterActual",
                columns: table => new
                {
                    FormMeasurementParameterActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMeasurementParameterActual", x => x.FormMeasurementParameterActualId);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameterActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameterActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMeasurementParameterActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMicroSection",
                columns: table => new
                {
                    FormMicroSectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    InstrumentId = table.Column<int>(nullable: true),
                    UOM = table.Column<string>(maxLength: 10, nullable: true),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: true),
                    LowerLimit = table.Column<double>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMicroSection", x => x.FormMicroSectionId);
                    table.ForeignKey(
                        name: "FK_FormMicroSection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMicroSection_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMicroSection_Instrument_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMicroSection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMicroSectionActual",
                columns: table => new
                {
                    FormMicroSectionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMicroSectionActual", x => x.FormMicroSectionActualId);
                    table.ForeignKey(
                        name: "FK_FormMicroSectionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMicroSectionActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMicroSectionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMPosition",
                columns: table => new
                {
                    FormMPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 20, nullable: false),
                    ITCode = table.Column<string>(maxLength: 20, nullable: false),
                    UOM = table.Column<string>(maxLength: 10, nullable: false),
                    Spec = table.Column<double>(nullable: true),
                    UpperLimit = table.Column<double>(nullable: false),
                    LowerLimit = table.Column<double>(nullable: false),
                    Accuracy = table.Column<int>(nullable: true),
                    SampleSize = table.Column<string>(maxLength: 20, nullable: true),
                    UpperLimit1 = table.Column<double>(nullable: true),
                    LowerLimit1 = table.Column<double>(nullable: true),
                    ITCode1 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit2 = table.Column<double>(nullable: true),
                    LowerLimit2 = table.Column<double>(nullable: true),
                    ITCode2 = table.Column<string>(maxLength: 255, nullable: true),
                    UpperLimit3 = table.Column<double>(nullable: true),
                    LowerLimit3 = table.Column<double>(nullable: true),
                    ITCode3 = table.Column<string>(maxLength: 255, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMPosition", x => x.FormMPositionId);
                    table.ForeignKey(
                        name: "FK_FormMPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMPosition_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMPositionActual",
                columns: table => new
                {
                    FormMPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    LineNo = table.Column<string>(maxLength: 200, nullable: false),
                    No = table.Column<int>(nullable: false),
                    ValueActual = table.Column<double>(nullable: true),
                    PositionCalcul = table.Column<double>(nullable: true),
                    PositionActual = table.Column<double>(nullable: true),
                    Result = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID = table.Column<string>(maxLength: 200, nullable: true),
                    Base1Actual = table.Column<double>(nullable: true),
                    Base2Actual = table.Column<double>(nullable: true),
                    Base3Actual = table.Column<double>(nullable: true),
                    InstrumentID1 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID2 = table.Column<string>(maxLength: 200, nullable: true),
                    InstrumentID3 = table.Column<string>(maxLength: 200, nullable: true),
                    PositionType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMPositionActual", x => x.FormMPositionActualId);
                    table.ForeignKey(
                        name: "FK_FormMPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMPositionActual_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormMPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormPackaging",
                columns: table => new
                {
                    FormPackagingId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ResultDesc = table.Column<string>(maxLength: 50, nullable: true),
                    Result = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPackaging", x => x.FormPackagingId);
                    table.ForeignKey(
                        name: "FK_FormPackaging_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormPackaging_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormPackaging_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormPartDateCode",
                columns: table => new
                {
                    FormPartDateCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    Requirement = table.Column<string>(maxLength: 255, nullable: true),
                    SupplierDC = table.Column<string>(maxLength: 255, nullable: true),
                    MFGDate = table.Column<string>(maxLength: 100, nullable: true),
                    Result = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPartDateCode", x => x.FormPartDateCodeId);
                    table.ForeignKey(
                        name: "FK_FormPartDateCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormPartDateCode_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormPartDateCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormPartSAPFailedQty",
                columns: table => new
                {
                    FormPartSAPFailedQtyId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    GRSNo = table.Column<string>(maxLength: 20, nullable: true),
                    PCCode = table.Column<string>(maxLength: 255, nullable: true),
                    FailedQty = table.Column<int>(nullable: true),
                    FormId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormPartSAPFailedQty", x => x.FormPartSAPFailedQtyId);
                    table.ForeignKey(
                        name: "FK_FormPartSAPFailedQty_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormPartSAPFailedQty_Form_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormPartSAPFailedQty_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormResultOrientedParameter",
                columns: table => new
                {
                    FormResultOrientedParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    ResultActual = table.Column<bool>(nullable: true),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: true),
                    InspectionDetails = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormResultOrientedParameter", x => x.FormResultOrientedParameterId);
                    table.ForeignKey(
                        name: "FK_FormResultOrientedParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormResultOrientedParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormResultOrientedParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormSAPParameter",
                columns: table => new
                {
                    FormSAPParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    SAPParameterExpected = table.Column<string>(maxLength: 50, nullable: false),
                    SAPParameterActual = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSAPParameter", x => x.FormSAPParameterId);
                    table.ForeignKey(
                        name: "FK_FormSAPParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormSAPParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSAPParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormSpecialParameter",
                columns: table => new
                {
                    FormSpecialParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 250, nullable: false),
                    ResultDesc = table.Column<string>(maxLength: 250, nullable: true),
                    Result = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSpecialParameter", x => x.FormSpecialParameterId);
                    table.ForeignKey(
                        name: "FK_FormSpecialParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormSpecialParameter_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormSpecialParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormStatus",
                columns: table => new
                {
                    FormStatusId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    StatusID = table.Column<string>(maxLength: 20, nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    LastTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormStatus", x => x.FormStatusId);
                    table.ForeignKey(
                        name: "FK_FormStatus_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormStatus_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormStatus_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTestReport",
                columns: table => new
                {
                    FormTestReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(maxLength: 200, nullable: false),
                    ResultExpected = table.Column<bool>(nullable: false),
                    TestCondition = table.Column<string>(maxLength: 200, nullable: true),
                    ResultActual = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTestReport", x => x.FormTestReportId);
                    table.ForeignKey(
                        name: "FK_FormTestReport_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormTestReport_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormTestReport_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormVIS",
                columns: table => new
                {
                    FormVISId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    AcceptanceQTY = table.Column<int>(nullable: true),
                    TotalFailedQTY = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormVIS", x => x.FormVISId);
                    table.ForeignKey(
                        name: "FK_FormVIS_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormVIS_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormVIS_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspection",
                columns: table => new
                {
                    InspectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    FormId = table.Column<int>(nullable: false),
                    Inspector = table.Column<string>(maxLength: 20, nullable: true),
                    InspectionResult = table.Column<string>(maxLength: 50, nullable: true),
                    ReportFullName = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspection", x => x.InspectionId);
                    table.ForeignKey(
                        name: "FK_Inspection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inspection_FormId",
                        column: x => x.FormId,
                        principalTable: "Form",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inspection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 50, "Admin_Buyer_Can_Access", "AdminBuyerCanAccess" },
                    { 278, "Admin_PartMPositionTolerance_Can_Access", "AdminPartMPositionToleranceCanAccess" },
                    { 277, "Admin_PartMicrosection_Can_Delete", "AdminPartMicrosectionCanDelete" },
                    { 276, "Admin_PartMicrosection_Can_Update", "AdminPartMicrosectionCanUpdate" },
                    { 275, "Admin_PartMicrosection_Can_Create", "AdminPartMicrosectionCanCreate" },
                    { 274, "Admin_PartMicrosection_Can_Access", "AdminPartMicrosectionCanAccess" },
                    { 273, "Admin_PartMeasurementParameter_Can_Delete", "AdminPartMeasurementParameterCanDelete" },
                    { 272, "Admin_PartMeasurementParameter_Can_Update", "AdminPartMeasurementParameterCanUpdate" },
                    { 271, "Admin_PartMeasurementParameter_Can_Create", "AdminPartMeasurementParameterCanCreate" },
                    { 270, "Admin_PartMeasurementParameter_Can_Access", "AdminPartMeasurementParameterCanAccess" },
                    { 269, "Admin_PartLPositionTolerance_Can_Delete", "AdminPartLPositionToleranceCanDelete" },
                    { 268, "Admin_PartLPositionTolerance_Can_Update", "AdminPartLPositionToleranceCanUpdate" },
                    { 267, "Admin_PartLPositionTolerance_Can_Create", "AdminPartLPositionToleranceCanCreate" },
                    { 266, "Admin_PartLPositionTolerance_Can_Access", "AdminPartLPositionToleranceCanAccess" },
                    { 265, "Admin_PartFunParameter_Can_Delete", "AdminPartFunParameterCanDelete" },
                    { 264, "Admin_PartFunParameter_Can_Update", "AdminPartFunParameterCanUpdate" },
                    { 263, "Admin_PartFunParameter_Can_Create", "AdminPartFunParameterCanCreate" },
                    { 262, "Admin_PartFunParameter_Can_Access", "AdminPartFunParameterCanAccess" },
                    { 279, "Admin_PartMPositionTolerance_Can_Create", "AdminPartMPositionToleranceCanCreate" },
                    { 261, "Admin_PartDateCode_Can_Delete", "AdminPartDateCodeCanDelete" },
                    { 280, "Admin_PartMPositionTolerance_Can_Update", "AdminPartMPositionToleranceCanUpdate" },
                    { 282, "Admin_PartResultOrientedParameter_Can_Access", "AdminPartResultOrientedParameterCanAccess" },
                    { 299, "Admin_FormCountParameter_Can_Create", "AdminFormCountParameterCanCreate" },
                    { 298, "Admin_FormCountParameter_Can_Access", "AdminFormCountParameterCanAccess" },
                    { 297, "Admin_FormBowTwistParameter_Can_Delete", "AdminFormBowTwistParameterCanDelete" },
                    { 296, "Admin_FormBowTwistParameter_Can_Update", "AdminFormBowTwistParameterCanUpdate" },
                    { 295, "Admin_FormBowTwistParameter_Can_Create", "AdminFormBowTwistParameterCanCreate" },
                    { 294, "Admin_FormBowTwistParameter_Can_Access", "AdminFormBowTwistParameterCanAccess" },
                    { 293, "Admin_Form_Can_Delete", "AdminFormCanDelete" },
                    { 292, "Admin_Form_Can_Update", "AdminFormCanUpdate" },
                    { 291, "Admin_Form_Can_Create", "AdminFormCanCreate" },
                    { 290, "Admin_Form_Can_Access", "AdminFormCanAccess" },
                    { 289, "Admin_PartTestReportParameter_Can_Delete", "AdminPartTestReportParameterCanDelete" },
                    { 288, "Admin_PartTestReportParameter_Can_Update", "AdminPartTestReportParameterCanUpdate" },
                    { 287, "Admin_PartTestReportParameter_Can_Create", "AdminPartTestReportParameterCanCreate" },
                    { 286, "Admin_PartTestReportParameter_Can_Access", "AdminPartTestReportParameterCanAccess" },
                    { 285, "Admin_PartResultOrientedParameter_Can_Delete", "AdminPartResultOrientedParameterCanDelete" },
                    { 284, "Admin_PartResultOrientedParameter_Can_Update", "AdminPartResultOrientedParameterCanUpdate" },
                    { 283, "Admin_PartResultOrientedParameter_Can_Create", "AdminPartResultOrientedParameterCanCreate" },
                    { 281, "Admin_PartMPositionTolerance_Can_Delete", "AdminPartMPositionToleranceCanDelete" },
                    { 300, "Admin_FormCountParameter_Can_Update", "AdminFormCountParameterCanUpdate" },
                    { 260, "Admin_PartDateCode_Can_Update", "AdminPartDateCodeCanUpdate" },
                    { 258, "Admin_PartDateCode_Can_Access", "AdminPartDateCodeCanAccess" },
                    { 236, "Admin_SAPPartInspectionPlan_Can_Update", "AdminSAPPartInspectionPlanCanUpdate" },
                    { 235, "Admin_SAPPartInspectionPlan_Can_Create", "AdminSAPPartInspectionPlanCanCreate" },
                    { 234, "Admin_SAPPartInspectionPlan_Can_Access", "AdminSAPPartInspectionPlanCanAccess" },
                    { 233, "Admin_GRS_Can_Delete", "AdminGRSCanDelete" },
                    { 232, "Admin_GRS_Can_Update", "AdminGRSCanUpdate" },
                    { 231, "Admin_GRS_Can_Create", "AdminGRSCanCreate" },
                    { 230, "Admin_GRS_Can_Access", "AdminGRSCanAccess" },
                    { 229, "Admin_Instrument_Can_Delete", "AdminInstrumentCanDelete" },
                    { 228, "Admin_Instrument_Can_Update", "AdminInstrumentCanUpdate" },
                    { 227, "Admin_Instrument_Can_Create", "AdminInstrumentCanCreate" },
                    { 226, "Admin_Instrument_Can_Access", "AdminInstrumentCanAccess" },
                    { 225, "Admin_InspectionTools_Can_Delete", "AdminInspectionToolsCanDelete" },
                    { 224, "Admin_InspectionTools_Can_Update", "AdminInspectionToolsCanUpdate" },
                    { 223, "Admin_InspectionTools_Can_Create", "AdminInspectionToolsCanCreate" },
                    { 222, "Admin_InspectionTools_Can_Access", "AdminInspectionToolsCanAccess" },
                    { 221, "Admin_Inspection_Can_Delete", "AdminInspectionCanDelete" },
                    { 220, "Admin_Inspection_Can_Update", "AdminInspectionCanUpdate" },
                    { 237, "Admin_SAPPartInspectionPlan_Can_Delete", "AdminSAPPartInspectionPlanCanDelete" },
                    { 259, "Admin_PartDateCode_Can_Create", "AdminPartDateCodeCanCreate" },
                    { 238, "Admin_PCCodeInspectionToolsType_Can_Access", "AdminPCCodeInspectionToolsTypeCanAccess" },
                    { 240, "Admin_PCCodeInspectionToolsType_Can_Update", "AdminPCCodeInspectionToolsTypeCanUpdate" },
                    { 257, "Admin_PartCountParameter_Can_Delete", "AdminPartCountParameterCanDelete" },
                    { 256, "Admin_PartCountParameter_Can_Update", "AdminPartCountParameterCanUpdate" },
                    { 255, "Admin_PartCountParameter_Can_Create", "AdminPartCountParameterCanCreate" },
                    { 254, "Admin_PartCountParameter_Can_Access", "AdminPartCountParameterCanAccess" },
                    { 253, "Admin_PartBowTwistParameter_Can_Delete", "AdminPartBowTwistParameterCanDelete" },
                    { 252, "Admin_PartBowTwistParameter_Can_Update", "AdminPartBowTwistParameterCanUpdate" },
                    { 251, "Admin_PartBowTwistParameter_Can_Create", "AdminPartBowTwistParameterCanCreate" },
                    { 250, "Admin_PartBowTwistParameter_Can_Access", "AdminPartBowTwistParameterCanAccess" },
                    { 249, "Admin_Part_Can_Delete", "AdminPartCanDelete" },
                    { 248, "Admin_Part_Can_Update", "AdminPartCanUpdate" },
                    { 247, "Admin_Part_Can_Create", "AdminPartCanCreate" },
                    { 246, "Admin_Part_Can_Access", "AdminPartCanAccess" },
                    { 245, "Admin_GRSSupplierForm_Can_Delete", "AdminGRSSupplierFormCanDelete" },
                    { 244, "Admin_GRSSupplierForm_Can_Update", "AdminGRSSupplierFormCanUpdate" },
                    { 243, "Admin_GRSSupplierForm_Can_Create", "AdminGRSSupplierFormCanCreate" },
                    { 242, "Admin_GRSSupplierForm_Can_Access", "AdminGRSSupplierFormCanAccess" },
                    { 241, "Admin_PCCodeInspectionToolsType_Can_Delete", "AdminPCCodeInspectionToolsTypeCanDelete" },
                    { 239, "Admin_PCCodeInspectionToolsType_Can_Create", "AdminPCCodeInspectionToolsTypeCanCreate" },
                    { 219, "Admin_Inspection_Can_Create", "AdminInspectionCanCreate" },
                    { 301, "Admin_FormCountParameter_Can_Delete", "AdminFormCountParameterCanDelete" },
                    { 303, "Admin_FormFunPara_Can_Create", "AdminFormFunParaCanCreate" },
                    { 362, "Admin_FormSAPParameter_Can_Access", "AdminFormSAPParameterCanAccess" },
                    { 361, "Admin_FormResultOrientedParameter_Can_Delete", "AdminFormResultOrientedParameterCanDelete" },
                    { 360, "Admin_FormResultOrientedParameter_Can_Update", "AdminFormResultOrientedParameterCanUpdate" },
                    { 359, "Admin_FormResultOrientedParameter_Can_Create", "AdminFormResultOrientedParameterCanCreate" },
                    { 358, "Admin_FormResultOrientedParameter_Can_Access", "AdminFormResultOrientedParameterCanAccess" },
                    { 357, "Admin_FormPartSAPFailedQty_Can_Delete", "AdminFormPartSAPFailedQtyCanDelete" },
                    { 356, "Admin_FormPartSAPFailedQty_Can_Update", "AdminFormPartSAPFailedQtyCanUpdate" },
                    { 355, "Admin_FormPartSAPFailedQty_Can_Create", "AdminFormPartSAPFailedQtyCanCreate" },
                    { 354, "Admin_FormPartSAPFailedQty_Can_Access", "AdminFormPartSAPFailedQtyCanAccess" },
                    { 353, "Admin_FormPartDateCode_Can_Delete", "AdminFormPartDateCodeCanDelete" },
                    { 352, "Admin_FormPartDateCode_Can_Update", "AdminFormPartDateCodeCanUpdate" },
                    { 351, "Admin_FormPartDateCode_Can_Create", "AdminFormPartDateCodeCanCreate" },
                    { 350, "Admin_FormPartDateCode_Can_Access", "AdminFormPartDateCodeCanAccess" },
                    { 349, "Admin_FormPackaging_Can_Delete", "AdminFormPackagingCanDelete" },
                    { 348, "Admin_FormPackaging_Can_Update", "AdminFormPackagingCanUpdate" },
                    { 347, "Admin_FormPackaging_Can_Create", "AdminFormPackagingCanCreate" },
                    { 346, "Admin_FormPackaging_Can_Access", "AdminFormPackagingCanAccess" },
                    { 363, "Admin_FormSAPParameter_Can_Create", "AdminFormSAPParameterCanCreate" },
                    { 345, "Admin_FormMPositionActual_Can_Delete", "AdminFormMPositionActualCanDelete" },
                    { 364, "Admin_FormSAPParameter_Can_Update", "AdminFormSAPParameterCanUpdate" },
                    { 366, "Admin_FormSpecialParameter_Can_Access", "AdminFormSpecialParameterCanAccess" },
                    { 383, "Admin_FormType_Can_Create", "AdminFormTypeCanCreate" },
                    { 382, "Admin_FormType_Can_Access", "AdminFormTypeCanAccess" },
                    { 381, "Admin_FormVIS_Can_Delete", "AdminFormVISCanDelete" },
                    { 380, "Admin_FormVIS_Can_Update", "AdminFormVISCanUpdate" },
                    { 379, "Admin_FormVIS_Can_Create", "AdminFormVISCanCreate" },
                    { 378, "Admin_FormVIS_Can_Access", "AdminFormVISCanAccess" },
                    { 377, "Admin_FormTestReport_Can_Delete", "AdminFormTestReportCanDelete" },
                    { 376, "Admin_FormTestReport_Can_Update", "AdminFormTestReportCanUpdate" },
                    { 375, "Admin_FormTestReport_Can_Create", "AdminFormTestReportCanCreate" },
                    { 374, "Admin_FormTestReport_Can_Access", "AdminFormTestReportCanAccess" },
                    { 373, "Admin_FormStatus_Can_Delete", "AdminFormStatusCanDelete" },
                    { 372, "Admin_FormStatus_Can_Update", "AdminFormStatusCanUpdate" },
                    { 371, "Admin_FormStatus_Can_Create", "AdminFormStatusCanCreate" },
                    { 370, "Admin_FormStatus_Can_Access", "AdminFormStatusCanAccess" },
                    { 369, "Admin_FormSpecialParameter_Can_Delete", "AdminFormSpecialParameterCanDelete" },
                    { 368, "Admin_FormSpecialParameter_Can_Update", "AdminFormSpecialParameterCanUpdate" },
                    { 367, "Admin_FormSpecialParameter_Can_Create", "AdminFormSpecialParameterCanCreate" },
                    { 365, "Admin_FormSAPParameter_Can_Delete", "AdminFormSAPParameterCanDelete" },
                    { 302, "Admin_FormFunPara_Can_Access", "AdminFormFunParaCanAccess" },
                    { 344, "Admin_FormMPositionActual_Can_Update", "AdminFormMPositionActualCanUpdate" },
                    { 342, "Admin_FormMPositionActual_Can_Access", "AdminFormMPositionActualCanAccess" },
                    { 320, "Admin_FormMeasurementParameter_Can_Update", "AdminFormMeasurementParameterCanUpdate" },
                    { 319, "Admin_FormMeasurementParameter_Can_Create", "AdminFormMeasurementParameterCanCreate" },
                    { 318, "Admin_FormMeasurementParameter_Can_Access", "AdminFormMeasurementParameterCanAccess" },
                    { 317, "Admin_FormLPositionActual_Can_Delete", "AdminFormLPositionActualCanDelete" },
                    { 316, "Admin_FormLPositionActual_Can_Update", "AdminFormLPositionActualCanUpdate" },
                    { 315, "Admin_FormLPositionActual_Can_Create", "AdminFormLPositionActualCanCreate" },
                    { 314, "Admin_FormLPositionActual_Can_Access", "AdminFormLPositionActualCanAccess" },
                    { 313, "Admin_FormLPosition_Can_Delete", "AdminFormLPositionCanDelete" },
                    { 312, "Admin_FormLPosition_Can_Update", "AdminFormLPositionCanUpdate" },
                    { 311, "Admin_FormLPosition_Can_Create", "AdminFormLPositionCanCreate" },
                    { 310, "Admin_FormLPosition_Can_Access", "AdminFormLPositionCanAccess" },
                    { 309, "Admin_FormFunParaActual_Can_Delete", "AdminFormFunParaActualCanDelete" },
                    { 308, "Admin_FormFunParaActual_Can_Update", "AdminFormFunParaActualCanUpdate" },
                    { 307, "Admin_FormFunParaActual_Can_Create", "AdminFormFunParaActualCanCreate" },
                    { 306, "Admin_FormFunParaActual_Can_Access", "AdminFormFunParaActualCanAccess" },
                    { 305, "Admin_FormFunPara_Can_Delete", "AdminFormFunParaCanDelete" },
                    { 304, "Admin_FormFunPara_Can_Update", "AdminFormFunParaCanUpdate" },
                    { 321, "Admin_FormMeasurementParameter_Can_Delete", "AdminFormMeasurementParameterCanDelete" },
                    { 343, "Admin_FormMPositionActual_Can_Create", "AdminFormMPositionActualCanCreate" },
                    { 322, "Admin_FormMeasurementParameterActual_Can_Access", "AdminFormMeasurementParameterActualCanAccess" },
                    { 324, "Admin_FormMeasurementParameterActual_Can_Update", "AdminFormMeasurementParameterActualCanUpdate" },
                    { 341, "Admin_FormMPosition_Can_Delete", "AdminFormMPositionCanDelete" },
                    { 340, "Admin_FormMPosition_Can_Update", "AdminFormMPositionCanUpdate" },
                    { 339, "Admin_FormMPosition_Can_Create", "AdminFormMPositionCanCreate" },
                    { 338, "Admin_FormMPosition_Can_Access", "AdminFormMPositionCanAccess" },
                    { 337, "Admin_FormMicroSectionActual_Can_Delete", "AdminFormMicroSectionActualCanDelete" },
                    { 336, "Admin_FormMicroSectionActual_Can_Update", "AdminFormMicroSectionActualCanUpdate" },
                    { 335, "Admin_FormMicroSectionActual_Can_Create", "AdminFormMicroSectionActualCanCreate" },
                    { 334, "Admin_FormMicroSectionActual_Can_Access", "AdminFormMicroSectionActualCanAccess" },
                    { 333, "Admin_FormMicroSection_Can_Delete", "AdminFormMicroSectionCanDelete" },
                    { 332, "Admin_FormMicroSection_Can_Update", "AdminFormMicroSectionCanUpdate" },
                    { 331, "Admin_FormMicroSection_Can_Create", "AdminFormMicroSectionCanCreate" },
                    { 330, "Admin_FormMicroSection_Can_Access", "AdminFormMicroSectionCanAccess" },
                    { 329, "Admin_FormBowTwistActual_Can_Delete", "AdminFormBowTwistActualCanDelete" },
                    { 328, "Admin_FormBowTwistActual_Can_Update", "AdminFormBowTwistActualCanUpdate" },
                    { 327, "Admin_FormBowTwistActual_Can_Create", "AdminFormBowTwistActualCanCreate" },
                    { 326, "Admin_FormBowTwistActual_Can_Access", "AdminFormBowTwistActualCanAccess" },
                    { 325, "Admin_FormMeasurementParameterActual_Can_Delete", "AdminFormMeasurementParameterActualCanDelete" },
                    { 323, "Admin_FormMeasurementParameterActual_Can_Create", "AdminFormMeasurementParameterActualCanCreate" },
                    { 218, "Admin_Inspection_Can_Access", "AdminInspectionCanAccess" },
                    { 217, "Admin_SupplierAttachment_Can_Delete", "AdminSupplierAttachmentCanDelete" },
                    { 216, "Admin_SupplierAttachment_Can_Update", "AdminSupplierAttachmentCanUpdate" },
                    { 109, "Admin_PartCAF_Can_Delete", "AdminPartCAFCanDelete" },
                    { 108, "Admin_PartCAF_Can_Update", "AdminPartCAFCanUpdate" },
                    { 107, "Admin_PartCAF_Can_Create", "AdminPartCAFCanCreate" },
                    { 106, "Admin_PartCAF_Can_Access", "AdminPartCAFCanAccess" },
                    { 105, "Admin_ParameterCategory_Can_Delete", "AdminParameterCategoryCanDelete" },
                    { 104, "Admin_ParameterCategory_Can_Update", "AdminParameterCategoryCanUpdate" },
                    { 103, "Admin_ParameterCategory_Can_Create", "AdminParameterCategoryCanCreate" },
                    { 102, "Admin_ParameterCategory_Can_Access", "AdminParameterCategoryCanAccess" },
                    { 101, "Admin_ParameterType_Can_Delete", "AdminParameterTypeCanDelete" },
                    { 100, "Admin_ParameterType_Can_Update", "AdminParameterTypeCanUpdate" },
                    { 99, "Admin_ParameterType_Can_Create", "AdminParameterTypeCanCreate" },
                    { 98, "Admin_ParameterType_Can_Access", "AdminParameterTypeCanAccess" },
                    { 97, "Admin_LotInspectionQty_Can_Delete", "AdminLotInspectionQtyCanDelete" },
                    { 96, "Admin_LotInspectionQty_Can_Update", "AdminLotInspectionQtyCanUpdate" },
                    { 95, "Admin_LotInspectionQty_Can_Create", "AdminLotInspectionQtyCanCreate" },
                    { 94, "Admin_LotInspectionQty_Can_Access", "AdminLotInspectionQtyCanAccess" },
                    { 93, "Admin_GRSSAPResult_Can_Delete", "AdminGRSSAPResultCanDelete" },
                    { 110, "Admin_PCCode_Can_Access", "AdminPCCodeCanAccess" },
                    { 92, "Admin_GRSSAPResult_Can_Update", "AdminGRSSAPResultCanUpdate" },
                    { 111, "Admin_PCCode_Can_Create", "AdminPCCodeCanCreate" },
                    { 113, "Admin_PCCode_Can_Delete", "AdminPCCodeCanDelete" },
                    { 130, "Admin_SupplierForm_Can_Access", "AdminSupplierFormCanAccess" },
                    { 129, "Admin_DispositionType_Can_Delete", "AdminDispositionTypeCanDelete" },
                    { 128, "Admin_DispositionType_Can_Update", "AdminDispositionTypeCanUpdate" },
                    { 127, "Admin_DispositionType_Can_Create", "AdminDispositionTypeCanCreate" },
                    { 126, "Admin_DispositionType_Can_Access", "AdminDispositionTypeCanAccess" },
                    { 125, "Admin_LotInspectionQty_Can_Delete", "AdminRosettaCanDelete" },
                    { 124, "Admin_Rosetta_Can_Update", "AdminRosettaCanUpdate" },
                    { 123, "Admin_Rosetta_Can_Create", "AdminRosettaCanCreate" },
                    { 122, "Admin_Rosetta_Can_Access", "AdminRosettaCanAccess" },
                    { 121, "Admin_ReceiveGoodsInfoManual_Can_Delete", "AdminReceiveGoodsInfoManualCanDelete" },
                    { 120, "Admin_ReceiveGoodsInfoManual_Can_Update", "AdminReceiveGoodsInfoManualCanUpdate" },
                    { 119, "Admin_ReceiveGoodsInfoManual_Can_Create", "AdminReceiveGoodsInfoManualCanCreate" },
                    { 118, "Admin_ReceiveGoodsInfoManual_Can_Access", "AdminReceiveGoodsInfoManualCanAccess" },
                    { 117, "Admin_ReceiveGoodsInfo_Can_Delete", "AdminReceiveGoodsInfoCanDelete" },
                    { 116, "Admin_ReceiveGoodsInfo_Can_Update", "AdminReceiveGoodsInfoCanUpdate" },
                    { 115, "Admin_ReceiveGoodsInfo_Can_Create", "AdminReceiveGoodsInfoCanCreate" },
                    { 114, "Admin_ReceiveGoodsInfo_Can_Access", "AdminReceiveGoodsInfoCanAccess" },
                    { 112, "Admin_PCCode_Can_Update", "AdminPCCodeCanUpdate" },
                    { 131, "Admin_SupplierForm_Can_Create", "AdminSupplierFormCanCreate" },
                    { 91, "Admin_GRSSAPResult_Can_Create", "AdminGRSSAPResultCanCreate" },
                    { 89, "Admin_InstrumentType_Can_Delete", "AdminInstrumentTypeCanDelete" },
                    { 67, "Admin_CTParameter_Can_Create", "AdminCTParameterCanCreate" },
                    { 66, "Admin_CTParameter_Can_Access", "AdminCTParameterCanAccess" },
                    { 65, "Admin_DefectType_Can_Delete", "AdminDefectTypeCanDelete" },
                    { 64, "Admin_DefectType_Can_Update", "AdminDefectTypeCanUpdate" },
                    { 63, "Admin_DefectType_Can_Create", "AdminDefectTypeCanCreate" },
                    { 62, "Admin_DefectType_Can_Access", "AdminDefectTypeCanAccess" },
                    { 61, "Admin_Customer_Can_Delete", "AdminCustomerCanDelete" },
                    { 60, "Admin_Customer_Can_Update", "AdminCustomerCanUpdate" },
                    { 59, "Admin_Customer_Can_Create", "AdminCustomerCanCreate" },
                    { 58, "Admin_Customer_Can_Access", "AdminCustomerCanAccess" },
                    { 57, "Admin_CompletedGRS_Can_Delete", "AdminCompletedGRSCanDelete" },
                    { 56, "Admin_CompletedGRS_Can_Update", "AdminCompletedGRSCanUpdate" },
                    { 55, "Admin_CompletedGRS_Can_Create", "AdminCompletedGRSCanCreate" },
                    { 54, "Admin_CompletedGRS_Can_Access", "AdminCompletedGRSCanAccess" },
                    { 53, "Admin_Buyer_Can_Delete", "AdminBuyerCanDelete" },
                    { 52, "Admin_Buyer_Can_Update", "AdminBuyerCanUpdate" },
                    { 51, "Admin_Buyer_Can_Create", "AdminBuyerCanCreate" },
                    { 68, "Admin_CTParameter_Can_Update", "AdminCTParameterCanUpdate" },
                    { 90, "Admin_GRSSAPResult_Can_Access", "AdminGRSSAPResultCanAccess" },
                    { 69, "Admin_CTParameter_Can_Delete", "AdminCTParameterCanDelete" },
                    { 71, "Admin_UOM_Can_Create", "AdminUOMCanCreate" },
                    { 88, "Admin_InstrumentType_Can_Update", "AdminInstrumentTypeCanUpdate" },
                    { 87, "Admin_InstrumentType_Can_Create", "AdminInstrumentTypeCanCreate" },
                    { 86, "Admin_InstrumentType_Can_Access", "AdminInstrumentTypeCanAccess" },
                    { 85, "Admin_InspectionToolsType_Can_Delete", "AdminInspectionToolsTypeCanDelete" },
                    { 84, "Admin_InspectionToolsType_Can_Update", "AdminInspectionToolsTypeCanUpdate" },
                    { 83, "Admin_InspectionToolsType_Can_Create", "AdminInspectionToolsTypeCanCreate" },
                    { 82, "Admin_InspectionToolsType_Can_Access", "AdminInspectionToolsTypeCanAccess" },
                    { 81, "Admin_Group_Can_Delete", "AdminGroupCanDelete" },
                    { 80, "Admin_Group_Can_Update", "AdminGroupCanUpdate" },
                    { 79, "Admin_Group_Can_Create", "AdminGroupCanCreate" },
                    { 78, "Admin_Group_Can_Access", "AdminGroupCanAccess" },
                    { 77, "Admin_GoodsReceiveUser_Can_Delete", "AdminGoodsReceiveUserCanDelete" },
                    { 76, "Admin_GoodsReceiveUser_Can_Update", "AdminGoodsReceiveUserCanUpdate" },
                    { 75, "Admin_GoodsReceiveUser_Can_Create", "AdminGoodsReceiveUserCanCreate" },
                    { 74, "Admin_GoodsReceiveUser_Can_Access", "AdminGoodsReceiveUserUOMCanAccess" },
                    { 73, "Admin_UOM_Can_Delete", "AdminUOMCanDelete" },
                    { 72, "Admin_UOM_Can_Update", "AdminUOMCanUpdate" },
                    { 70, "Admin_UOM_Can_Access", "AdminUOMCanAccess" },
                    { 132, "Admin_SupplierForm_Can_Update", "AdminSupplierFormCanUpdate" },
                    { 133, "Admin_SupplierForm_Can_Delete", "AdminSupplierFormCanDelete" },
                    { 134, "Admin_SupplierFormVIS_Can_Access", "AdminSupplierFormVISCanAccess" },
                    { 194, "Admin_SupplierFormMeasurementParameterActual_Can_Access", "AdminSupplierFormMeasurementParameterActualCanAccess" },
                    { 193, "Admin_SupplierFormMeasurementParameter_Can_Delete", "AdminSupplierFormMeasurementParameterCanDelete" },
                    { 192, "Admin_SupplierFormMeasurementParameter_Can_Update", "AdminSupplierFormMeasurementParameterCanUpdate" },
                    { 191, "Admin_SupplierFormMeasurementParameter_Can_Create", "AdminSupplierFormMeasurementParameterCanCreate" },
                    { 190, "Admin_SupplierFormMeasurementParameter_Can_Access", "AdminSupplierFormMeasurementParameterCanAccess" },
                    { 189, "Admin_SupplierFormLPositionActual_Can_Delete", "AdminSupplierFormLPositionActualCanDelete" },
                    { 188, "Admin_SupplierFormLPositionActual_Can_Update", "AdminSupplierFormLPositionActualCanUpdate" },
                    { 187, "Admin_SupplierFormLPositionActual_Can_Create", "AdminSupplierFormLPositionActualCanCreate" },
                    { 186, "Admin_SupplierFormLPositionActual_Can_Access", "AdminSupplierFormLPositionActualCanAccess" },
                    { 185, "Admin_SupplierFormLPosition_Can_Delete", "AdminSupplierFormLPositionCanDelete" },
                    { 184, "Admin_SupplierFormLPosition_Can_Update", "AdminSupplierFormLPositionCanUpdate" },
                    { 183, "Admin_SupplierFormLPosition_Can_Create", "AdminSupplierFormLPositionCanCreate" },
                    { 182, "Admin_SupplierFormLPosition_Can_Access", "AdminSupplierFormLPositionCanAccess" },
                    { 181, "Admin_SupplierFormFunParaActual_Can_Delete", "AdminSupplierFormFunParaActualCanDelete" },
                    { 180, "Admin_SupplierFormFunParaActual_Can_Update", "AdminSupplierFormFunParaActualCanUpdate" },
                    { 179, "Admin_SupplierFormFunParaActual_Can_Create", "AdminSupplierFormFunParaActualCanCreate" },
                    { 178, "Admin_SupplierFormFunParaActual_Can_Access", "AdminSupplierFormFunParaActualCanAccess" },
                    { 195, "Admin_SupplierFormMeasurementParameterActual_Can_Create", "AdminSupplierFormMeasurementParameterActualCanCreate" },
                    { 177, "Admin_SupplierFormFunPara_Can_Delete", "AdminSupplierFormFunParaCanDelete" },
                    { 196, "Admin_SupplierFormMeasurementParameterActual_Can_Update", "AdminSupplierFormMeasurementParameterActualCanUpdate" },
                    { 198, "Admin_SupplierFormMicroSection_Can_Access", "AdminSupplierFormMicroSectionCanAccess" },
                    { 215, "Admin_SupplierAttachment_Can_Create", "AdminSupplierAttachmentCanCreate" },
                    { 214, "Admin_SupplierAttachment_Can_Access", "AdminSupplierAttachmentCanAccess" },
                    { 213, "Admin_SupplierFormMPositionActual_Can_Delete", "AdminSupplierFormMPositionActualCanDelete" },
                    { 212, "Admin_SupplierFormMPositionActual_Can_Update", "AdminSupplierFormMPositionActualCanUpdate" },
                    { 211, "Admin_SupplierFormMPositionActual_Can_Create", "AdminSupplierFormMPositionActualCanCreate" },
                    { 210, "Admin_SupplierFormMPositionActual_Can_Access", "AdminSupplierFormMPositionActualCanAccess" },
                    { 209, "Admin_SupplierFormMPosition_Can_Delete", "AdminSupplierFormMPositionCanDelete" },
                    { 208, "Admin_SupplierFormMPosition_Can_Update", "AdminSupplierFormMPositionCanUpdate" },
                    { 207, "Admin_SupplierFormMPosition_Can_Create", "AdminSupplierFormMPositionCanCreate" },
                    { 206, "Admin_SupplierFormMPosition_Can_Access", "AdminSupplierFormMPositionCanAccess" },
                    { 205, "Admin_SupplierFormMicroSectionActual_Can_Delete", "AdminSupplierFormMicroSectionActualCanDelete" },
                    { 204, "Admin_SupplierFormMicroSectionActual_Can_Update", "AdminSupplierFormMicroSectionActualCanUpdate" },
                    { 203, "Admin_SupplierFormMicroSectionActual_Can_Create", "AdminSupplierFormMicroSectionActualCanCreate" },
                    { 202, "Admin_SupplierFormMicroSectionActual_Can_Access", "AdminSupplierFormMicroSectionActualCanAccess" },
                    { 201, "Admin_SupplierFormMicroSection_Can_Delete", "AdminSupplierFormMicroSectionCanDelete" },
                    { 200, "Admin_SupplierFormMicroSection_Can_Update", "AdminSupplierFormMicroSectionCanUpdate" },
                    { 199, "Admin_SupplierFormMicroSection_Can_Create", "AdminSupplierFormMicroSectionCanCreate" },
                    { 197, "Admin_SupplierFormMeasurementParameterActual_Can_Delete", "AdminSupplierFormMeasurementParameterActualCanDelete" },
                    { 176, "Admin_SupplierFormFunPara_Can_Update", "AdminSupplierFormFunParaCanUpdate" },
                    { 175, "Admin_SupplierFormFunPara_Can_Create", "AdminSupplierFormFunParaCanCreate" },
                    { 174, "Admin_SupplierFormFunPara_Can_Access", "AdminSupplierFormFunParaCanAccess" },
                    { 151, "Admin_SupplierFormBowTwistParameter_Can_Create", "AdminSupplierFormBowTwistParameterCanCreate" },
                    { 150, "Admin_SupplierFormBowTwistParameter_Can_Access", "AdminSupplierFormBowTwistParameterCanAccess" },
                    { 149, "Admin_SupplierFormSAPParameter_Can_Delete", "AdminSupplierFormSAPParameterCanDelete" },
                    { 148, "Admin_SupplierFormSAPParameter_Can_Update", "AdminSupplierFormSAPParameterCanUpdate" },
                    { 147, "Admin_SupplierFormSAPParameter_Can_Create", "AdminSupplierFormSAPParameterCanCreate" },
                    { 146, "Admin_SupplierFormSAPParameter_Can_Access", "AdminSupplierFormSAPParameterCanAccess" },
                    { 145, "Admin_SupplierFormTestReport_Can_Delete", "AdminSupplierFormTestReportCanDelete" },
                    { 144, "Admin_SupplierFormTestReport_Can_Update", "AdminSupplierFormTestReportCanUpdate" },
                    { 143, "Admin_SupplierFormTestReport_Can_Create", "AdminSupplierFormTestReportCanCreate" },
                    { 142, "Admin_SupplierFormTestReport_Can_Access", "AdminSupplierFormTestReportCanAccess" },
                    { 141, "Admin_SupplierFormCountParameter_Can_Delete", "AdminSupplierFormCountParameterCanDelete" },
                    { 140, "Admin_SupplierFormCountParameter_Can_Update", "AdminSupplierFormCountParameterCanUpdate" },
                    { 139, "Admin_SupplierFormCountParameter_Can_Create", "AdminSupplierFormCountParameterCanCreate" },
                    { 138, "Admin_SupplierFormCountParameter_Can_Access", "AdminSupplierFormCountParameterCanAccess" },
                    { 137, "Admin_SupplierFormVIS_Can_Delete", "AdminSupplierFormVISCanDelete" },
                    { 136, "Admin_SupplierFormVIS_Can_Update", "AdminSupplierFormVISCanUpdate" },
                    { 135, "Admin_SupplierFormVIS_Can_Create", "AdminSupplierFormVISCanCreate" },
                    { 152, "Admin_SupplierFormBowTwistParameter_Can_Update", "AdminSupplierFormBowTwistParameterCanUpdate" },
                    { 153, "Admin_SupplierFormBowTwistParameter_Can_Delete", "AdminSupplierFormBowTwistParameterCanDelete" },
                    { 154, "Admin_SupplierFormSpecialParameter_Can_Access", "AdminSupplierFormSpecialParameterCanAccess" },
                    { 155, "Admin_SupplierFormSpecialParameter_Can_Create", "AdminSupplierFormSpecialParameterCanCreate" },
                    { 173, "Admin_SupplierFormBowTwistActual_Can_Delete", "AdminSupplierFormBowTwistActualCanDelete" },
                    { 172, "Admin_SupplierFormBowTwistActual_Can_Update", "AdminSupplierFormBowTwistActualCanUpdate" },
                    { 171, "Admin_SupplierFormBowTwistActual_Can_Create", "AdminSupplierFormBowTwistActualCanCreate" },
                    { 170, "Admin_SupplierFormBowTwistActual_Can_Access", "AdminSupplierFormBowTwistActualCanAccess" },
                    { 169, "Admin_SupplierFormPartDateCode_Can_Delete", "AdminSupplierFormPartDateCodeCanDelete" },
                    { 168, "Admin_SupplierFormPartDateCode_Can_Update", "AdminSupplierFormPartDateCodeCanUpdate" },
                    { 167, "Admin_SupplierFormPartDateCode_Can_Create", "AdminSupplierFormPartDateCodeCanCreate" },
                    { 166, "Admin_SupplierFormPartDateCode_Can_Access", "AdminSupplierFormPartDateCodeCanAccess" },
                    { 384, "Admin_FormType_Can_Update", "AdminFormTypeCanUpdate" },
                    { 165, "Admin_SupplierFormPackaging_Can_Delete", "AdminSupplierFormPackagingCanDelete" },
                    { 163, "Admin_SupplierFormPackaging_Can_Create", "AdminSupplierFormPackagingCanCreate" },
                    { 162, "Admin_SupplierFormPackaging_Can_Access", "AdminSupplierFormPackagingCanAccess" },
                    { 161, "Admin_SupplierFormResultOrientedParameter_Can_Delete", "AdminSupplierFormResultOrientedParameterCanDelete" },
                    { 160, "Admin_SupplierFormResultOrientedParameter_Can_Update", "AdminSupplierFormResultOrientedParameterCanUpdate" },
                    { 159, "Admin_SupplierFormResultOrientedParameter_Can_Create", "AdminSupplierFormResultOrientedParameterCanCreate" },
                    { 158, "Admin_SupplierFormResultOrientedParameter_Can_Access", "AdminSupplierFormResultOrientedParameterCanAccess" },
                    { 157, "Admin_SupplierFormSpecialParameter_Can_Delete", "AdminSupplierFormSpecialParameterCanDelete" },
                    { 156, "Admin_SupplierFormSpecialParameter_Can_Update", "AdminSupplierFormSpecialParameterCanUpdate" },
                    { 164, "Admin_SupplierFormPackaging_Can_Update", "AdminSupplierFormPackagingCanUpdate" },
                    { 385, "Admin_FormType_Can_Delete", "AdminFormTypeCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Buyer_CreatedBy",
                table: "Buyer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Buyer_LastUpdatedBy",
                table: "Buyer",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedGRS_CreatedBy",
                table: "CompletedGRS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CompletedGRS_LastUpdatedBy",
                table: "CompletedGRS",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CTParameter_CreatedBy",
                table: "CTParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CTParameter_LastUpdatedBy",
                table: "CTParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_CreatedBy",
                table: "Customer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_LastUpdatedBy",
                table: "Customer",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DefectType_CreatedBy",
                table: "DefectType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DefectType_LastUpdatedBy",
                table: "DefectType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DispositionType_CreatedBy",
                table: "DispositionType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DispositionType_LastUpdatedBy",
                table: "DispositionType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Form_CreatedBy",
                table: "Form",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Form_FormTypeId",
                table: "Form",
                column: "FormTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_GRSId",
                table: "Form",
                column: "GRSId");

            migrationBuilder.CreateIndex(
                name: "IX_Form_LastUpdatedBy",
                table: "Form",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistActual_CreatedBy",
                table: "FormBowTwistActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistActual_FormId",
                table: "FormBowTwistActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistActual_LastUpdatedBy",
                table: "FormBowTwistActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistParameter_CreatedBy",
                table: "FormBowTwistParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistParameter_FormId",
                table: "FormBowTwistParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormBowTwistParameter_LastUpdatedBy",
                table: "FormBowTwistParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormCountParameter_CreatedBy",
                table: "FormCountParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormCountParameter_FormId",
                table: "FormCountParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCountParameter_InspectionToolsId",
                table: "FormCountParameter",
                column: "InspectionToolsId");

            migrationBuilder.CreateIndex(
                name: "IX_FormCountParameter_LastUpdatedBy",
                table: "FormCountParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunPara_CreatedBy",
                table: "FormFunPara",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunPara_FormId",
                table: "FormFunPara",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunPara_LastUpdatedBy",
                table: "FormFunPara",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunParaActual_CreatedBy",
                table: "FormFunParaActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunParaActual_FormId",
                table: "FormFunParaActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFunParaActual_LastUpdatedBy",
                table: "FormFunParaActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPosition_CreatedBy",
                table: "FormLPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPosition_FormId",
                table: "FormLPosition",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPosition_LastUpdatedBy",
                table: "FormLPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPositionActual_CreatedBy",
                table: "FormLPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPositionActual_FormId",
                table: "FormLPositionActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormLPositionActual_LastUpdatedBy",
                table: "FormLPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameter_CreatedBy",
                table: "FormMeasurementParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameter_FormId",
                table: "FormMeasurementParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameter_InstrumentId",
                table: "FormMeasurementParameter",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameter_LastUpdatedBy",
                table: "FormMeasurementParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameterActual_CreatedBy",
                table: "FormMeasurementParameterActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameterActual_FormId",
                table: "FormMeasurementParameterActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMeasurementParameterActual_LastUpdatedBy",
                table: "FormMeasurementParameterActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSection_CreatedBy",
                table: "FormMicroSection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSection_FormId",
                table: "FormMicroSection",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSection_InstrumentId",
                table: "FormMicroSection",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSection_LastUpdatedBy",
                table: "FormMicroSection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSectionActual_CreatedBy",
                table: "FormMicroSectionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSectionActual_FormId",
                table: "FormMicroSectionActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMicroSectionActual_LastUpdatedBy",
                table: "FormMicroSectionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPosition_CreatedBy",
                table: "FormMPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPosition_FormId",
                table: "FormMPosition",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPosition_LastUpdatedBy",
                table: "FormMPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPositionActual_CreatedBy",
                table: "FormMPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPositionActual_FormId",
                table: "FormMPositionActual",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMPositionActual_LastUpdatedBy",
                table: "FormMPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPackaging_CreatedBy",
                table: "FormPackaging",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPackaging_FormId",
                table: "FormPackaging",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormPackaging_LastUpdatedBy",
                table: "FormPackaging",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartDateCode_CreatedBy",
                table: "FormPartDateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartDateCode_FormId",
                table: "FormPartDateCode",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartDateCode_LastUpdatedBy",
                table: "FormPartDateCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartSAPFailedQty_CreatedBy",
                table: "FormPartSAPFailedQty",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartSAPFailedQty_FormId",
                table: "FormPartSAPFailedQty",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormPartSAPFailedQty_LastUpdatedBy",
                table: "FormPartSAPFailedQty",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormResultOrientedParameter_CreatedBy",
                table: "FormResultOrientedParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormResultOrientedParameter_FormId",
                table: "FormResultOrientedParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormResultOrientedParameter_LastUpdatedBy",
                table: "FormResultOrientedParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormSAPParameter_CreatedBy",
                table: "FormSAPParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormSAPParameter_FormId",
                table: "FormSAPParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSAPParameter_LastUpdatedBy",
                table: "FormSAPParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormSpecialParameter_CreatedBy",
                table: "FormSpecialParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormSpecialParameter_FormId",
                table: "FormSpecialParameter",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSpecialParameter_LastUpdatedBy",
                table: "FormSpecialParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormStatus_CreatedBy",
                table: "FormStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormStatus_FormId",
                table: "FormStatus",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormStatus_LastUpdatedBy",
                table: "FormStatus",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormTestReport_CreatedBy",
                table: "FormTestReport",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormTestReport_FormId",
                table: "FormTestReport",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTestReport_LastUpdatedBy",
                table: "FormTestReport",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormType_CreatedBy",
                table: "FormType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormType_LastUpdatedBy",
                table: "FormType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormVIS_CreatedBy",
                table: "FormVIS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FormVIS_FormId",
                table: "FormVIS",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_FormVIS_LastUpdatedBy",
                table: "FormVIS",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceiveUser_CreatedBy",
                table: "GoodsReceiveUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceiveUser_LastUpdatedBy",
                table: "GoodsReceiveUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Group_CreatedBy",
                table: "Group",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Group_LastUpdatedBy",
                table: "Group",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRS_CreatedBy",
                table: "GRS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "UK_GRS",
                table: "GRS",
                column: "GRSNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GRS_LastUpdatedBy",
                table: "GRS",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRS_PartNo",
                table: "GRS",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSAPResult_CreatedBy",
                table: "GRSSAPResult",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSAPResult_LastUpdatedBy",
                table: "GRSSAPResult",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSupplierForm_CreatedBy",
                table: "GRSSupplierForm",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSupplierForm_GRSId",
                table: "GRSSupplierForm",
                column: "GRSId");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSupplierForm_LastUpdatedBy",
                table: "GRSSupplierForm",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GRSSupplierForm_SupplierFormId",
                table: "GRSSupplierForm",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_CreatedBy",
                table: "Inspection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_FormId",
                table: "Inspection",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_Inspection_LastUpdatedBy",
                table: "Inspection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTools_CreatedBy",
                table: "InspectionTools",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTools_InspectionToolsTypeId",
                table: "InspectionTools",
                column: "InspectionToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionTools_LastUpdatedBy",
                table: "InspectionTools",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsType_CreatedBy",
                table: "InspectionToolsType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsType_LastUpdatedBy",
                table: "InspectionToolsType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_CreatedBy",
                table: "Instrument",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_InstrumentTypeId",
                table: "Instrument",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Instrument_LastUpdatedBy",
                table: "Instrument",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentType_CreatedBy",
                table: "InstrumentType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InstrumentType_LastUpdatedBy",
                table: "InstrumentType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotInspectionQty_CreatedBy",
                table: "LotInspectionQty",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LotInspectionQty_LastUpdatedBy",
                table: "LotInspectionQty",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterCategory_CreatedBy",
                table: "ParameterCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterCategory_LastUpdatedBy",
                table: "ParameterCategory",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterCategory_PCCodeId",
                table: "ParameterCategory",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterType_CreatedBy",
                table: "ParameterType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterType_LastUpdatedBy",
                table: "ParameterType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Part_CreatedBy",
                table: "Part",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Part_CustomerId",
                table: "Part",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Part_LastUpdatedBy",
                table: "Part",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "UK_Part_PartNo",
                table: "Part",
                column: "PartNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_CreatedBy",
                table: "PartBowTwistParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_LastUpdatedBy",
                table: "PartBowTwistParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_PartNo",
                table: "PartBowTwistParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartCAF_CreatedBy",
                table: "PartCAF",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartCAF_LastUpdatedBy",
                table: "PartCAF",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_CreatedBy",
                table: "PartCountParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_InspectionToolsTypeId",
                table: "PartCountParameter",
                column: "InspectionToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_LastUpdatedBy",
                table: "PartCountParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_PartNo",
                table: "PartCountParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartDateCode_CreatedBy",
                table: "PartDateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartDateCode_LastUpdatedBy",
                table: "PartDateCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartDateCode_PartNo",
                table: "PartDateCode",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_CreatedBy",
                table: "PartFunParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_LastUpdatedBy",
                table: "PartFunParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_PartNo",
                table: "PartFunParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_CreatedBy",
                table: "PartLPositionTolerance",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_LastUpdatedBy",
                table: "PartLPositionTolerance",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartLPositionTolerance_PartNo",
                table: "PartLPositionTolerance",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_CreatedBy",
                table: "PartMeasurementParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_LastUpdatedBy",
                table: "PartMeasurementParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_PartNo",
                table: "PartMeasurementParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_CreatedBy",
                table: "PartMicrosection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_LastUpdatedBy",
                table: "PartMicrosection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_PartNo",
                table: "PartMicrosection",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_CreatedBy",
                table: "PartMPositionTolerance",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_LastUpdatedBy",
                table: "PartMPositionTolerance",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartMPositionTolerance_PartNo",
                table: "PartMPositionTolerance",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_CreatedBy",
                table: "PartResultOrientedParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_LastUpdatedBy",
                table: "PartResultOrientedParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_PartNo",
                table: "PartResultOrientedParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_CreatedBy",
                table: "PartTestReportParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_LastUpdatedBy",
                table: "PartTestReportParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportParameter_PartNo",
                table: "PartTestReportParameter",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_PCCode_CreatedBy",
                table: "PCCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PCCode_LastUpdatedBy",
                table: "PCCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PCCodeInspectionToolsType_CreatedBy",
                table: "PCCodeInspectionToolsType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PCCodeInspectionToolsType_InspectionToolsTypeId",
                table: "PCCodeInspectionToolsType",
                column: "InspectionToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PCCodeInspectionToolsType_LastUpdatedBy",
                table: "PCCodeInspectionToolsType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PCCodeInspectionToolsType_PCCodeId",
                table: "PCCodeInspectionToolsType",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveGoodsInfo_CreatedBy",
                table: "ReceiveGoodsInfo",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveGoodsInfo_LastUpdatedBy",
                table: "ReceiveGoodsInfo",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveGoodsInfoManual_CreatedBy",
                table: "ReceiveGoodsInfoManual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ReceiveGoodsInfoManual_LastUpdatedBy",
                table: "ReceiveGoodsInfoManual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Rosetta_CreatedBy",
                table: "Rosetta",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Rosetta_LastUpdatedBy",
                table: "Rosetta",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_CreatedBy",
                table: "SAPPartInspectionPlan",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_LastUpdatedBy",
                table: "SAPPartInspectionPlan",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PCCodeId",
                table: "SAPPartInspectionPlan",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PartId",
                table: "SAPPartInspectionPlan",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAttachment_CreatedBy",
                table: "SupplierAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAttachment_LastUpdatedBy",
                table: "SupplierAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierAttachment_SupplierFormId",
                table: "SupplierAttachment",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierForm_CreatedBy",
                table: "SupplierForm",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierForm_LastUpdatedBy",
                table: "SupplierForm",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistActual_CreatedBy",
                table: "SupplierFormBowTwistActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistActual_LastUpdatedBy",
                table: "SupplierFormBowTwistActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistActual_SupplierFormId",
                table: "SupplierFormBowTwistActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistParameter_CreatedBy",
                table: "SupplierFormBowTwistParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistParameter_LastUpdatedBy",
                table: "SupplierFormBowTwistParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormBowTwistParameter_SupplierFormId",
                table: "SupplierFormBowTwistParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormCountParameter_CreatedBy",
                table: "SupplierFormCountParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormCountParameter_LastUpdatedBy",
                table: "SupplierFormCountParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormCountParameter_SupplierFormId",
                table: "SupplierFormCountParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunPara_CreatedBy",
                table: "SupplierFormFunPara",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunPara_LastUpdatedBy",
                table: "SupplierFormFunPara",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunPara_SupplierFormId",
                table: "SupplierFormFunPara",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunParaActual_CreatedBy",
                table: "SupplierFormFunParaActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunParaActual_LastUpdatedBy",
                table: "SupplierFormFunParaActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormFunParaActual_SupplierFormId",
                table: "SupplierFormFunParaActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPosition_CreatedBy",
                table: "SupplierFormLPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPosition_LastUpdatedBy",
                table: "SupplierFormLPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPosition_SupplierFormId",
                table: "SupplierFormLPosition",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPositionActual_CreatedBy",
                table: "SupplierFormLPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPositionActual_LastUpdatedBy",
                table: "SupplierFormLPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormLPositionActual_SupplierFormId",
                table: "SupplierFormLPositionActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameter_CreatedBy",
                table: "SupplierFormMeasurementParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameter_LastUpdatedBy",
                table: "SupplierFormMeasurementParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameter_SupplierFormId",
                table: "SupplierFormMeasurementParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameterActual_CreatedBy",
                table: "SupplierFormMeasurementParameterActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameterActual_LastUpdatedBy",
                table: "SupplierFormMeasurementParameterActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMeasurementParameterActual_SupplierFormId",
                table: "SupplierFormMeasurementParameterActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSection_CreatedBy",
                table: "SupplierFormMicroSection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSection_LastUpdatedBy",
                table: "SupplierFormMicroSection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSection_SupplierFormId",
                table: "SupplierFormMicroSection",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSectionActual_CreatedBy",
                table: "SupplierFormMicroSectionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSectionActual_LastUpdatedBy",
                table: "SupplierFormMicroSectionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMicroSectionActual_SupplierFormId",
                table: "SupplierFormMicroSectionActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPosition_CreatedBy",
                table: "SupplierFormMPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPosition_LastUpdatedBy",
                table: "SupplierFormMPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPosition_SupplierFormId",
                table: "SupplierFormMPosition",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPositionActual_CreatedBy",
                table: "SupplierFormMPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPositionActual_LastUpdatedBy",
                table: "SupplierFormMPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormMPositionActual_SupplierFormId",
                table: "SupplierFormMPositionActual",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPackaging_CreatedBy",
                table: "SupplierFormPackaging",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPackaging_LastUpdatedBy",
                table: "SupplierFormPackaging",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPackaging_SupplierFormId",
                table: "SupplierFormPackaging",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPartDateCode_CreatedBy",
                table: "SupplierFormPartDateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPartDateCode_LastUpdatedBy",
                table: "SupplierFormPartDateCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormPartDateCode_SupplierFormId",
                table: "SupplierFormPartDateCode",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormResultOrientedParameter_CreatedBy",
                table: "SupplierFormResultOrientedParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormResultOrientedParameter_LastUpdatedBy",
                table: "SupplierFormResultOrientedParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormResultOrientedParameter_SupplierFormId",
                table: "SupplierFormResultOrientedParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSAPParameter_CreatedBy",
                table: "SupplierFormSAPParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSAPParameter_LastUpdatedBy",
                table: "SupplierFormSAPParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSAPParameter_SupplierFormId",
                table: "SupplierFormSAPParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSpecialParameter_CreatedBy",
                table: "SupplierFormSpecialParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSpecialParameter_LastUpdatedBy",
                table: "SupplierFormSpecialParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormSpecialParameter_SupplierFormId",
                table: "SupplierFormSpecialParameter",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_CreatedBy",
                table: "SupplierFormTestReport",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_LastUpdatedBy",
                table: "SupplierFormTestReport",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormTestReport_SupplierFormId",
                table: "SupplierFormTestReport",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormVIS_CreatedBy",
                table: "SupplierFormVIS",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormVIS_LastUpdatedBy",
                table: "SupplierFormVIS",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFormVIS_SupplierFormId",
                table: "SupplierFormVIS",
                column: "SupplierFormId");

            migrationBuilder.CreateIndex(
                name: "IX_UOM_CreatedBy",
                table: "UOM",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UOM_LastUpdatedBy",
                table: "UOM",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_CreatedBy",
                table: "UserCustomer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_CustomerId",
                table: "UserCustomer",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_LastUpdatedBy",
                table: "UserCustomer",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserCustomer_UserId",
                table: "UserCustomer",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Buyer");

            migrationBuilder.DropTable(
                name: "CompletedGRS");

            migrationBuilder.DropTable(
                name: "CTParameter");

            migrationBuilder.DropTable(
                name: "DefectType");

            migrationBuilder.DropTable(
                name: "DispositionType");

            migrationBuilder.DropTable(
                name: "FormBowTwistActual");

            migrationBuilder.DropTable(
                name: "FormBowTwistParameter");

            migrationBuilder.DropTable(
                name: "FormCountParameter");

            migrationBuilder.DropTable(
                name: "FormFunPara");

            migrationBuilder.DropTable(
                name: "FormFunParaActual");

            migrationBuilder.DropTable(
                name: "FormLPosition");

            migrationBuilder.DropTable(
                name: "FormLPositionActual");

            migrationBuilder.DropTable(
                name: "FormMeasurementParameter");

            migrationBuilder.DropTable(
                name: "FormMeasurementParameterActual");

            migrationBuilder.DropTable(
                name: "FormMicroSection");

            migrationBuilder.DropTable(
                name: "FormMicroSectionActual");

            migrationBuilder.DropTable(
                name: "FormMPosition");

            migrationBuilder.DropTable(
                name: "FormMPositionActual");

            migrationBuilder.DropTable(
                name: "FormPackaging");

            migrationBuilder.DropTable(
                name: "FormPartDateCode");

            migrationBuilder.DropTable(
                name: "FormPartSAPFailedQty");

            migrationBuilder.DropTable(
                name: "FormResultOrientedParameter");

            migrationBuilder.DropTable(
                name: "FormSAPParameter");

            migrationBuilder.DropTable(
                name: "FormSpecialParameter");

            migrationBuilder.DropTable(
                name: "FormStatus");

            migrationBuilder.DropTable(
                name: "FormTestReport");

            migrationBuilder.DropTable(
                name: "FormVIS");

            migrationBuilder.DropTable(
                name: "GoodsReceiveUser");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "GRSSAPResult");

            migrationBuilder.DropTable(
                name: "GRSSupplierForm");

            migrationBuilder.DropTable(
                name: "Inspection");

            migrationBuilder.DropTable(
                name: "LotInspectionQty");

            migrationBuilder.DropTable(
                name: "ParameterCategory");

            migrationBuilder.DropTable(
                name: "ParameterType");

            migrationBuilder.DropTable(
                name: "PartBowTwistParameter");

            migrationBuilder.DropTable(
                name: "PartCAF");

            migrationBuilder.DropTable(
                name: "PartCountParameter");

            migrationBuilder.DropTable(
                name: "PartDateCode");

            migrationBuilder.DropTable(
                name: "PartFunParameter");

            migrationBuilder.DropTable(
                name: "PartLPositionTolerance");

            migrationBuilder.DropTable(
                name: "PartMeasurementParameter");

            migrationBuilder.DropTable(
                name: "PartMicrosection");

            migrationBuilder.DropTable(
                name: "PartMPositionTolerance");

            migrationBuilder.DropTable(
                name: "PartResultOrientedParameter");

            migrationBuilder.DropTable(
                name: "PartTestReportParameter");

            migrationBuilder.DropTable(
                name: "PCCodeInspectionToolsType");

            migrationBuilder.DropTable(
                name: "ReceiveGoodsInfo");

            migrationBuilder.DropTable(
                name: "ReceiveGoodsInfoManual");

            migrationBuilder.DropTable(
                name: "Rosetta");

            migrationBuilder.DropTable(
                name: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "SupplierAttachment");

            migrationBuilder.DropTable(
                name: "SupplierFormBowTwistActual");

            migrationBuilder.DropTable(
                name: "SupplierFormBowTwistParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormCountParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormFunPara");

            migrationBuilder.DropTable(
                name: "SupplierFormFunParaActual");

            migrationBuilder.DropTable(
                name: "SupplierFormLPosition");

            migrationBuilder.DropTable(
                name: "SupplierFormLPositionActual");

            migrationBuilder.DropTable(
                name: "SupplierFormMeasurementParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormMeasurementParameterActual");

            migrationBuilder.DropTable(
                name: "SupplierFormMicroSection");

            migrationBuilder.DropTable(
                name: "SupplierFormMicroSectionActual");

            migrationBuilder.DropTable(
                name: "SupplierFormMPosition");

            migrationBuilder.DropTable(
                name: "SupplierFormMPositionActual");

            migrationBuilder.DropTable(
                name: "SupplierFormPackaging");

            migrationBuilder.DropTable(
                name: "SupplierFormPartDateCode");

            migrationBuilder.DropTable(
                name: "SupplierFormResultOrientedParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormSAPParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormSpecialParameter");

            migrationBuilder.DropTable(
                name: "SupplierFormTestReport");

            migrationBuilder.DropTable(
                name: "SupplierFormVIS");

            migrationBuilder.DropTable(
                name: "UOM");

            migrationBuilder.DropTable(
                name: "UserCustomer");

            migrationBuilder.DropTable(
                name: "InspectionTools");

            migrationBuilder.DropTable(
                name: "Instrument");

            migrationBuilder.DropTable(
                name: "Form");

            migrationBuilder.DropTable(
                name: "PCCode");

            migrationBuilder.DropTable(
                name: "SupplierForm");

            migrationBuilder.DropTable(
                name: "InspectionToolsType");

            migrationBuilder.DropTable(
                name: "InstrumentType");

            migrationBuilder.DropTable(
                name: "FormType");

            migrationBuilder.DropTable(
                name: "GRS");

            migrationBuilder.DropTable(
                name: "Part");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 385);

            migrationBuilder.AlterColumn<int>(
                name: "RolePermissionId",
                table: "RolePermission",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:IdentitySequenceOptions", "'40', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'47', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
