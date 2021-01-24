using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPCORE.Migrations
{
    public partial class Totalinvestmentandpayoutdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "investmentMasters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrokerName = table.Column<string>(nullable: true),
                    Investment = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_investmentMasters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "payOutDetails",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DayProfit = table.Column<int>(nullable: false),
                    DayLoss = table.Column<int>(nullable: false),
                    Totalprofit = table.Column<int>(nullable: false),
                    Totalloss = table.Column<int>(nullable: false),
                    DayPayout = table.Column<int>(nullable: false),
                    TotalPayOut = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payOutDetails", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "investmentMasters");

            migrationBuilder.DropTable(
                name: "payOutDetails");
        }
    }
}
