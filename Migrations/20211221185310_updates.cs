using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "dokumenti",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "dokumenti",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "dokumenti");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "dokumenti");
        }
    }
}
