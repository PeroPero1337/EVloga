using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class addedOsebaToDokument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Oseba",
                table: "dokumenti",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oseba",
                table: "dokumenti");
        }
    }
}
