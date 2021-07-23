using Microsoft.EntityFrameworkCore.Migrations;

namespace PetCare.Data.Migrations
{
    public partial class RemovedAgeFromPets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Pets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Age",
                table: "Pets",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
