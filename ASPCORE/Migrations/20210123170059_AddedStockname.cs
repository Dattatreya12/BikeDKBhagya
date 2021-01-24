using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCORE.Migrations
{
    public partial class AddedStockname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StockName",
                table: "payOutDetails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockName",
                table: "payOutDetails");
        }
    }
}
