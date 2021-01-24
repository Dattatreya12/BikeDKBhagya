using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCORE.Migrations
{
    public partial class addedbrokerid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bid",
                table: "payOutDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bid",
                table: "payOutDetails");
        }
    }
}
