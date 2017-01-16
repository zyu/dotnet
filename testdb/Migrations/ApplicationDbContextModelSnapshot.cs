using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using testdb.Data;

namespace testdb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("testdb.Model.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Grade");

                    b.Property<int>("StudentID");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("testdb.Model.Merchant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActivateTime");

                    b.Property<short>("Area");

                    b.Property<string>("AreaName");

                    b.Property<short>("AreaNo");

                    b.Property<int>("ChargeNum");

                    b.Property<string>("Contacter");

                    b.Property<string>("ContacterIdCard");

                    b.Property<int>("ContacterSex");

                    b.Property<string>("CouponCode");

                    b.Property<int>("CutLevel");

                    b.Property<decimal>("DiscountsByGame");

                    b.Property<decimal>("DiscountsByMobile");

                    b.Property<decimal>("DiscountsByQQ");

                    b.Property<decimal>("DiscountsByT");

                    b.Property<decimal>("DiscountsByUnicom");

                    b.Property<int>("FavourableType");

                    b.Property<bool>("FirstOrderCharge");

                    b.Property<string>("HeadImg");

                    b.Property<bool>("IsActivate");

                    b.Property<bool>("IsLicensed");

                    b.Property<bool>("IsLimit");

                    b.Property<bool>("IsMissed");

                    b.Property<bool>("IsToken");

                    b.Property<bool>("IsVerify");

                    b.Property<bool>("IsVip");

                    b.Property<bool>("IsWholesale");

                    b.Property<DateTime>("LastVisitDate");

                    b.Property<string>("Latitude");

                    b.Property<int>("Level");

                    b.Property<DateTime>("LicensedTime");

                    b.Property<string>("Longitude");

                    b.Property<short>("LotteryNum");

                    b.Property<string>("Mac");

                    b.Property<int>("MerchantType");

                    b.Property<string>("NickName");

                    b.Property<decimal>("OrderLevel");

                    b.Property<decimal>("OrderLevelDay");

                    b.Property<int>("OriginSalerId");

                    b.Property<int>("PartEmployeeId");

                    b.Property<DateTime>("PwdUpdateTime");

                    b.Property<int>("RouteId");

                    b.Property<string>("RouteName");

                    b.Property<int>("RouteOrderNum");

                    b.Property<int>("SalerId");

                    b.Property<DateTime>("SignAgreementCountTime");

                    b.Property<int>("SpecialEmployeeId");

                    b.Property<int>("Status");

                    b.Property<int>("StoreCredit");

                    b.Property<int>("StoreType");

                    b.Property<string>("UpdateMobile");

                    b.Property<int>("WareHouseId");

                    b.Property<string>("WareHouseName");

                    b.HasKey("Id");

                    b.ToTable("Merchants");
                });

            modelBuilder.Entity("testdb.Model.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddTime");

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<string>("FirstMidName");

                    b.Property<string>("LastName");

                    b.Property<string>("Secret");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("testdb.Model.Enrollment", b =>
                {
                    b.HasOne("testdb.Model.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
