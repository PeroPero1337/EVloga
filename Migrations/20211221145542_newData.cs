using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EVloga.Migrations
{
    public partial class newData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "podatki",
                columns: table => new
                {
                    OsebniId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Priimek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RojDan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KrajRojstva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMSO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Davcna = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_podatki", x => x.OsebniId);
                });

            migrationBuilder.CreateTable(
                name: "dokumenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    OsebniId = table.Column<int>(type: "int", nullable: true),
                    OsebniPodatkiOsebniId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dokumenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dokumenti_podatki_OsebniPodatkiOsebniId",
                        column: x => x.OsebniPodatkiOsebniId,
                        principalTable: "podatki",
                        principalColumn: "OsebniId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dokumenti_OsebniPodatkiOsebniId",
                table: "dokumenti",
                column: "OsebniPodatkiOsebniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dokumenti");

            migrationBuilder.DropTable(
                name: "podatki");
        }
    }
}
