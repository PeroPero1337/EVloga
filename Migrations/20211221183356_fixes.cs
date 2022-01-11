using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dokumenti_podatki_OsebniPodatkiOsebniId",
                table: "dokumenti");

            migrationBuilder.DropIndex(
                name: "IX_dokumenti_OsebniPodatkiOsebniId",
                table: "dokumenti");

            migrationBuilder.DropColumn(
                name: "OsebniId",
                table: "dokumenti");

            migrationBuilder.DropColumn(
                name: "OsebniPodatkiOsebniId",
                table: "dokumenti");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OsebniId",
                table: "dokumenti",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OsebniPodatkiOsebniId",
                table: "dokumenti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_dokumenti_OsebniPodatkiOsebniId",
                table: "dokumenti",
                column: "OsebniPodatkiOsebniId");

            migrationBuilder.AddForeignKey(
                name: "FK_dokumenti_podatki_OsebniPodatkiOsebniId",
                table: "dokumenti",
                column: "OsebniPodatkiOsebniId",
                principalTable: "podatki",
                principalColumn: "OsebniId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
