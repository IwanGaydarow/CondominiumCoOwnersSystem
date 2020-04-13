using Microsoft.EntityFrameworkCore.Migrations;

namespace CondominiumCoOwnersSystem.Data.Migrations
{
    public partial class ChangeTypeOfDestributionType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TypeOfDestribution",
                table: "FundRepairs",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeOfDestribution",
                table: "FundRepairs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
