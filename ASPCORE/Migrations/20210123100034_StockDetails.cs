using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCORE.Migrations
{
    public partial class StockDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockInvestorDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    TotalCapital = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockInvestorDetails", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "masterStockDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StockHolderName = table.Column<string>(nullable: true),
                    StockName = table.Column<string>(nullable: true),
                    Mode = table.Column<string>(nullable: true),
                    StockType = table.Column<string>(nullable: true),
                    TotalQuantity = table.Column<int>(nullable: false),
                    BuyRate = table.Column<int>(nullable: false),
                    SellRate = table.Column<int>(nullable: false),
                    Investment = table.Column<int>(nullable: false),
                    TotalInvestment = table.Column<int>(nullable: false),
                    Profit = table.Column<int>(nullable: false),
                    Loss = table.Column<int>(nullable: false),
                    TotalGainLoss = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    SID = table.Column<int>(nullable: false),
                    stockInvestorDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_masterStockDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_masterStockDetails_StockInvestorDetails_stockInvestorDetailsID",
                        column: x => x.stockInvestorDetailsID,
                        principalTable: "StockInvestorDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_masterStockDetails_stockInvestorDetailsID",
                table: "masterStockDetails",
                column: "stockInvestorDetailsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "masterStockDetails");

            migrationBuilder.DropTable(
                name: "StockInvestorDetails");
        }
    }
}
