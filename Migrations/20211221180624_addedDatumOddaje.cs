using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class addedDatumOddaje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumOddaje",
                table: "podatki",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumOddaje",
                table: "podatki");
        }
    }
}
