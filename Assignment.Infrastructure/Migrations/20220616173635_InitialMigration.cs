using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Investor",
                columns: table => new
                {
                    InvestorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InvestorName = table.Column<string>(maxLength: 100, nullable: true),
                    ContactNo = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    City = table.Column<string>(maxLength: 100, nullable: true),
                    ShareValue = table.Column<int>(nullable: false),
                    SharePrice = table.Column<int>(nullable: false),
                    Nationality = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    IDType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investor", x => x.InvestorID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Investor");
        }
    }
}
