using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InstaRoi.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Element",
                columns: table => new
                {
                    Type = table.Column<string>(maxLength: 255, nullable: false),
                    investmentFieldID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Element__F9B8A48A1BF64AE0", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Investment",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Field = table.Column<int>(nullable: false),
                    investmentType = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MarketingElements",
                columns: table => new
                {
                    elementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    conversionPercentage = table.Column<decimal>(type: "decimal", nullable: false),
                    conversionValue = table.Column<int>(nullable: false),
                    elementDescription = table.Column<string>(maxLength: 255, nullable: true),
                    elementName = table.Column<string>(maxLength: 255, nullable: false),
                    elementType = table.Column<string>(maxLength: 255, nullable: false),
                    endDate = table.Column<DateTime>(type: "date", nullable: true),
                    investment1 = table.Column<int>(nullable: true),
                    investment2 = table.Column<int>(nullable: true),
                    investment3 = table.Column<int>(nullable: true),
                    investment4 = table.Column<int>(nullable: true),
                    investment5 = table.Column<int>(nullable: true),
                    investment6 = table.Column<int>(nullable: true),
                    investmentField = table.Column<string>(maxLength: 255, nullable: true),
                    numberOfLeads = table.Column<int>(nullable: false),
                    profit = table.Column<decimal>(type: "decimal", nullable: true),
                    roi = table.Column<decimal>(type: "decimal", nullable: true),
                    roiPercentage = table.Column<decimal>(type: "decimal", nullable: true),
                    startDate = table.Column<DateTime>(type: "date", nullable: true),
                    userID = table.Column<int>(nullable: true),
                    userName = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Marketin__A4DA082A26D137C7", x => x.elementID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Element");

            migrationBuilder.DropTable(
                name: "Investment");

            migrationBuilder.DropTable(
                name: "MarketingElements");
        }
    }
}
