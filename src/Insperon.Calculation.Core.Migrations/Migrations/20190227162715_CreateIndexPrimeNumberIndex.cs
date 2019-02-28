using Microsoft.EntityFrameworkCore.Migrations;

namespace Insperon.Calculation.Core.Migrations
{
    public partial class CreateIndexPrimeNumberIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Calculation_Core_PrimeNumber_Index",
                table: "Calculation_Core_PrimeNumber",
                column: "Index",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Calculation_Core_PrimeNumber_Index",
                table: "Calculation_Core_PrimeNumber");

      
        }
    }
}
