namespace CondominiumCoOwnersSystem.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddingInhabitantsInApartmentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Inhabitants",
                table: "Apartments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Inhabitants",
                table: "ApartmentMontlyObligations",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inhabitants",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "Inhabitants",
                table: "ApartmentMontlyObligations");
        }
    }
}
