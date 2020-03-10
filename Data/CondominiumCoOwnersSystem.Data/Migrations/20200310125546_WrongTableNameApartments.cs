namespace CondominiumCoOwnersSystem.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class WrongTableNameApartments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentMontlyObligations_Apartment_ApartmentId",
                table: "ApartmentMontlyObligations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment");

            migrationBuilder.RenameTable(
                name: "Apartment",
                newName: "Apartments");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_UserId",
                table: "Apartments",
                newName: "IX_Apartments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_IsDeleted",
                table: "Apartments",
                newName: "IX_Apartments_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_BuildingId",
                table: "Apartments",
                newName: "IX_Apartments_BuildingId");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingServiceSubscriptionId",
                table: "Services",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentMontlyObligations_Apartments_ApartmentId",
                table: "ApartmentMontlyObligations",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_AspNetUsers_UserId",
                table: "Apartments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentMontlyObligations_Apartments_ApartmentId",
                table: "ApartmentMontlyObligations");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_AspNetUsers_UserId",
                table: "Apartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments");

            migrationBuilder.RenameTable(
                name: "Apartments",
                newName: "Apartment");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_UserId",
                table: "Apartment",
                newName: "IX_Apartment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_IsDeleted",
                table: "Apartment",
                newName: "IX_Apartment_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_BuildingId",
                table: "Apartment",
                newName: "IX_Apartment_BuildingId");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingServiceSubscriptionId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                table: "Apartment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Buildings_BuildingId",
                table: "Apartment",
                column: "BuildingId",
                principalTable: "Buildings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentMontlyObligations_Apartment_ApartmentId",
                table: "ApartmentMontlyObligations",
                column: "ApartmentId",
                principalTable: "Apartment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
