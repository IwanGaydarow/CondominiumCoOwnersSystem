namespace CondominiumCoOwnersSystem.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialAddingApplicationDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    FullAddress = table.Column<string>(maxLength: 150, nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    FundRepairId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    TypeOfServices = table.Column<string>(maxLength: 150, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 300, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Floor = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Apartment_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Apartment_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingAdditionalRepairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    MadeBy = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingAdditionalRepairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingAdditionalRepairs_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FundRepairs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Fee = table.Column<decimal>(nullable: false),
                    TypeOfDestribution = table.Column<string>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundRepairs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FundRepairs_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CompanyTypeId = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_CompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "CompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingUtilityBills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    UtilityId = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingUtilityBills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingUtilityBills_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingUtilityBills_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentMontlyObligations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    MontlyObligation = table.Column<decimal>(nullable: false),
                    ApartmentId = table.Column<int>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentMontlyObligations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApartmentMontlyObligations_Apartment_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyServiceSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    BuildingId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyServiceSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyServiceSubscriptions_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyServiceSubscriptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyServiceSubscriptions_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MontlyServiceFees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: false),
                    Subscription = table.Column<int>(nullable: true),
                    CompanyServiceSubscriptionId = table.Column<int>(nullable: false),
                    Fee = table.Column<decimal>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MontlyServiceFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MontlyServiceFees_CompanyServiceSubscriptions_CompanyServiceSubscriptionId",
                        column: x => x.CompanyServiceSubscriptionId,
                        principalTable: "CompanyServiceSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_BuildingId",
                table: "Apartment",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_IsDeleted",
                table: "Apartment",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_UserId",
                table: "Apartment",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentMontlyObligations_ApartmentId",
                table: "ApartmentMontlyObligations",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentMontlyObligations_IsDeleted",
                table: "ApartmentMontlyObligations",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingAdditionalRepairs_BuildingId",
                table: "BuildingAdditionalRepairs",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingAdditionalRepairs_IsDeleted",
                table: "BuildingAdditionalRepairs",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_IsDeleted",
                table: "Buildings",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingUtilityBills_BuildingId",
                table: "BuildingUtilityBills",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingUtilityBills_IsDeleted",
                table: "BuildingUtilityBills",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingUtilityBills_UtilityId",
                table: "BuildingUtilityBills",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CompanyTypeId",
                table: "Companies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IsDeleted",
                table: "Companies",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceSubscriptions_BuildingId",
                table: "CompanyServiceSubscriptions",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceSubscriptions_CompanyId",
                table: "CompanyServiceSubscriptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceSubscriptions_IsDeleted",
                table: "CompanyServiceSubscriptions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyServiceSubscriptions_ServiceId",
                table: "CompanyServiceSubscriptions",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTypes_IsDeleted",
                table: "CompanyTypes",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_FundRepairs_BuildingId",
                table: "FundRepairs",
                column: "BuildingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FundRepairs_IsDeleted",
                table: "FundRepairs",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_MontlyServiceFees_CompanyServiceSubscriptionId",
                table: "MontlyServiceFees",
                column: "CompanyServiceSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MontlyServiceFees_IsDeleted",
                table: "MontlyServiceFees",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Services_IsDeleted",
                table: "Services",
                column: "IsDeleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApartmentMontlyObligations");

            migrationBuilder.DropTable(
                name: "BuildingAdditionalRepairs");

            migrationBuilder.DropTable(
                name: "BuildingUtilityBills");

            migrationBuilder.DropTable(
                name: "FundRepairs");

            migrationBuilder.DropTable(
                name: "MontlyServiceFees");

            migrationBuilder.DropTable(
                name: "Apartment");

            migrationBuilder.DropTable(
                name: "Utilities");

            migrationBuilder.DropTable(
                name: "CompanyServiceSubscriptions");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "CompanyTypes");
        }
    }
}
