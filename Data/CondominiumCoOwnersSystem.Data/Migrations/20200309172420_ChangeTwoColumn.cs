namespace CondominiumCoOwnersSystem.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ChangeTwoColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MontlyServiceFees");

            migrationBuilder.DropTable(
                name: "CompanyServiceSubscriptions");

            migrationBuilder.AddColumn<int>(
                name: "BuildingServiceSubscriptionId",
                table: "Services",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BuildingServiceSubscriptions",
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
                    Fee = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingServiceSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingServiceSubscriptions_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingServiceSubscriptions_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyMontlyServiceFees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeletedOn = table.Column<DateTime>(nullable: true),
                    BuildingServiceSubscriptionId = table.Column<int>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyMontlyServiceFees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyMontlyServiceFees_BuildingServiceSubscriptions_BuildingServiceSubscriptionId",
                        column: x => x.BuildingServiceSubscriptionId,
                        principalTable: "BuildingServiceSubscriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_BuildingServiceSubscriptionId",
                table: "Services",
                column: "BuildingServiceSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingServiceSubscriptions_BuildingId",
                table: "BuildingServiceSubscriptions",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingServiceSubscriptions_CompanyId",
                table: "BuildingServiceSubscriptions",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingServiceSubscriptions_IsDeleted",
                table: "BuildingServiceSubscriptions",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMontlyServiceFees_BuildingServiceSubscriptionId",
                table: "CompanyMontlyServiceFees",
                column: "BuildingServiceSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyMontlyServiceFees_IsDeleted",
                table: "CompanyMontlyServiceFees",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_BuildingServiceSubscriptions_BuildingServiceSubscriptionId",
                table: "Services",
                column: "BuildingServiceSubscriptionId",
                principalTable: "BuildingServiceSubscriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_BuildingServiceSubscriptions_BuildingServiceSubscriptionId",
                table: "Services");

            migrationBuilder.DropTable(
                name: "CompanyMontlyServiceFees");

            migrationBuilder.DropTable(
                name: "BuildingServiceSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Services_BuildingServiceSubscriptionId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "BuildingServiceSubscriptionId",
                table: "Services");

            migrationBuilder.CreateTable(
                name: "CompanyServiceSubscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyServiceSubscriptionId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Subscription = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_MontlyServiceFees_CompanyServiceSubscriptionId",
                table: "MontlyServiceFees",
                column: "CompanyServiceSubscriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_MontlyServiceFees_IsDeleted",
                table: "MontlyServiceFees",
                column: "IsDeleted");
        }
    }
}
