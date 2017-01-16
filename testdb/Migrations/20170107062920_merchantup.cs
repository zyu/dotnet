using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace testdb.Migrations
{
    public partial class merchantup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Student_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivateTime = table.Column<DateTime>(nullable: false),
                    Area = table.Column<short>(nullable: false),
                    AreaName = table.Column<string>(nullable: true),
                    AreaNo = table.Column<short>(nullable: false),
                    ChargeNum = table.Column<int>(nullable: false),
                    Contacter = table.Column<string>(nullable: true),
                    ContacterIdCard = table.Column<string>(nullable: true),
                    ContacterSex = table.Column<int>(nullable: false),
                    CouponCode = table.Column<string>(nullable: true),
                    CutLevel = table.Column<int>(nullable: false),
                    DiscountsByGame = table.Column<decimal>(nullable: false),
                    DiscountsByMobile = table.Column<decimal>(nullable: false),
                    DiscountsByQQ = table.Column<decimal>(nullable: false),
                    DiscountsByT = table.Column<decimal>(nullable: false),
                    DiscountsByUnicom = table.Column<decimal>(nullable: false),
                    FavourableType = table.Column<int>(nullable: false),
                    FirstOrderCharge = table.Column<bool>(nullable: false),
                    HeadImg = table.Column<string>(nullable: true),
                    IsActivate = table.Column<bool>(nullable: false),
                    IsLicensed = table.Column<bool>(nullable: false),
                    IsLimit = table.Column<bool>(nullable: false),
                    IsMissed = table.Column<bool>(nullable: false),
                    IsToken = table.Column<bool>(nullable: false),
                    IsVerify = table.Column<bool>(nullable: false),
                    IsVip = table.Column<bool>(nullable: false),
                    IsWholesale = table.Column<bool>(nullable: false),
                    LastVisitDate = table.Column<DateTime>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    LicensedTime = table.Column<DateTime>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    LotteryNum = table.Column<short>(nullable: false),
                    Mac = table.Column<string>(nullable: true),
                    MerchantType = table.Column<int>(nullable: false),
                    NickName = table.Column<string>(nullable: true),
                    OrderLevel = table.Column<decimal>(nullable: false),
                    OrderLevelDay = table.Column<decimal>(nullable: false),
                    OriginSalerId = table.Column<int>(nullable: false),
                    PartEmployeeId = table.Column<int>(nullable: false),
                    PwdUpdateTime = table.Column<DateTime>(nullable: false),
                    RouteId = table.Column<int>(nullable: false),
                    RouteName = table.Column<string>(nullable: true),
                    RouteOrderNum = table.Column<int>(nullable: false),
                    SalerId = table.Column<int>(nullable: false),
                    SignAgreementCountTime = table.Column<DateTime>(nullable: false),
                    SpecialEmployeeId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StoreCredit = table.Column<int>(nullable: false),
                    StoreType = table.Column<int>(nullable: false),
                    UpdateMobile = table.Column<string>(nullable: true),
                    WareHouseId = table.Column<int>(nullable: false),
                    WareHouseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Student",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Student",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentID",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Students",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Student_StudentID",
                table: "Enrollments",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");
        }
    }
}
