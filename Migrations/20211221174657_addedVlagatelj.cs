using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class addedVlagatelj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vlagatelj",
                table: "podatki",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vlagatelj",
                table: "podatki");
        }
    }
}
