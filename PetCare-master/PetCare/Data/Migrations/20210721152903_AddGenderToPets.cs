﻿namespace PetCare.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class AddGenderToPets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Pets");
        }
    }
}
