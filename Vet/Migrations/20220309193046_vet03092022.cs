using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vet.Migrations
{
    public partial class vet03092022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    PayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsultId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FeePaymentCount = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.PayId);
                    table.ForeignKey(
                        name: "FK_Pays_Consults_ConsultId",
                        column: x => x.ConsultId,
                        principalTable: "Consults",
                        principalColumn: "ConsultId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quotas",
                columns: table => new
                {
                    QuotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PayId = table.Column<int>(type: "int", nullable: false),
                    QuotaDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    PaymentAmount = table.Column<int>(type: "int", nullable: false),
                    Rest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotas", x => x.QuotaId);
                    table.ForeignKey(
                        name: "FK_Quotas_Pays_PayId",
                        column: x => x.PayId,
                        principalTable: "Pays",
                        principalColumn: "PayId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pays_ConsultId",
                table: "Pays",
                column: "ConsultId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotas_PayId",
                table: "Quotas",
                column: "PayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotas");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}
