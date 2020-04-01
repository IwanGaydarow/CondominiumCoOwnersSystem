namespace CondominiumCoOwnersSystem.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class FixedUserIdtoNotRequiredAndAddingColumnIdealParts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Apartments",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<decimal>(
                name: "IdealParts",
                table: "Apartments",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdealParts",
                table: "Apartments");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Apartments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
