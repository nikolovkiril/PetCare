using Microsoft.EntityFrameworkCore.Migrations;

namespace PetCare.Data.Migrations
{
    public partial class AddAutobiographyToEnployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autobiography",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autobiography",
                table: "Employees");
        }
    }
}
