using Microsoft.EntityFrameworkCore.Migrations;

namespace Vet.Migrations
{
    public partial class vet03102022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeePaymentCount",
                table: "Pays");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeePaymentCount",
                table: "Pays",
                type: "int",
                maxLength: 20,
                nullable: false,
                defaultValue: 0);
        }
    }
}
