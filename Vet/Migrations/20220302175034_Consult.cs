using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vet.Migrations
{
    public partial class Consult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consults",
                columns: table => new
                {
                    ConsultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetId = table.Column<int>(type: "int", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PetName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ConsultDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PetWeight = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    PetTemperature = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MedicalChart = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consults", x => x.ConsultId);
                    table.ForeignKey(
                        name: "FK_Consults_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "PetId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consults_PetId",
                table: "Consults",
                column: "PetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consults");
        }
    }
}
